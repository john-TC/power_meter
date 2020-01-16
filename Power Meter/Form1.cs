using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using CustomerData;
using System.Data.SqlClient;

namespace Power_Meter
{
    public partial class Form1 : Form
    {
        private delegate void UpdateStatusDelegate(string status);
        Stopwatch stopwatch = new Stopwatch();
        Residential res = new Residential();
        Commercial com = new Commercial();
        Industrial ind = new Industrial();
        private CancellationTokenSource _canceller;
        double elapsedTime = 0;
        double total = 0;
        int industry = 0;
        double millis;
        double seconds;
        double minutes;
        double hours;
        double currentKwh = 0;
        double prevKwh;
        double totalKwh;
        double currentMillis;
        double prevMillis;
        int prevRow;
        char selectedZone;
        string connString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PowerMeter.mdf;Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }
        private void UpdateBill(string status)
        {
            if (this.txtMeter.InvokeRequired)
            {
                this.Invoke(new UpdateStatusDelegate(this.UpdateBill), new object[] { status });
                return;
            }
            this.txtMeter.Text = status;
            SqlConnection connection = new SqlConnection(connString);
            string updateStatement =
                "UPDATE Customers "
                + "SET ChargeAmmount = " + status
                + " WHERE AccountNo = " + dataGridView1.Rows[prevRow].Cells["AccountNo"].Value;
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //connection.Close();

                var select = "SELECT * FROM Customers";
                var c = new SqlConnection(connString); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Rows[prevRow].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[prevRow].Cells[0];

                //SqlConnection connection = new SqlConnection(connString);
                string custNoStatement = "SELECT COUNT(AccountNo) AS CustNo FROM Customers;";
                string totalSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers;";
                string totalResSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers WHERE CustomerType = 'R'";
                string totalComSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers WHERE CustomerType = 'C'";
                string totalIndSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers WHERE CustomerType = 'I'";
                SqlCommand CustNoCommand = new SqlCommand(custNoStatement, connection);
                SqlCommand TotalSumCommand = new SqlCommand(totalSumStatement, connection);
                SqlCommand TotalResSumCommand = new SqlCommand(totalResSumStatement, connection);
                SqlCommand TotalComSumCommand = new SqlCommand(totalComSumStatement, connection);
                SqlCommand TotalIndSumCommand = new SqlCommand(totalIndSumStatement, connection);
                try
                {
                    //connection.Open();
                    SqlDataReader reader = CustNoCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        txtCustNo.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                    reader = TotalSumCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTotSum.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                    reader = TotalResSumCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        txtResSum.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                    reader = TotalComSumCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        txtComSum.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                    reader = TotalIndSumCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        txtIndSum.Text = reader.GetValue(0).ToString();
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }

        }
        private void UpdateKwh(string status)
        {
            if (this.txtMeter.InvokeRequired)
            {
                this.Invoke(new UpdateStatusDelegate(this.UpdateKwh), new object[] { status });
                return;
            }
            this.txtKwh.Text = status;
        }
        private void NudPower_ValueChanged(object sender, EventArgs e)
        {
            prevKwh = prevKwh + currentKwh;
            currentKwh = 0;
            prevMillis = currentMillis;
        }
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            prevRow = dataGridView1.CurrentRow.Index;
            if (selectedZone == 'R')
            {
                industry = 0;
            }
            else if (selectedZone == 'C')
            {
                industry = 1;
            }
            else
            {
                industry = 2;
            }
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            _canceller = new CancellationTokenSource();
            await Task.Run(() =>
            {
                do
                {
                    if (Convert.ToInt32(nudPower.Value) == 0)
                    {
                        stopwatch.Stop();
                    }
                    else
                    {
                        stopwatch.Start();

                        elapsedTime = stopwatch.ElapsedMilliseconds;
                        currentMillis = elapsedTime - prevMillis;

                        millis = currentMillis;
                        seconds = millis / 1000;
                        minutes = seconds / 60;
                        hours = minutes / 60;
                        currentKwh = hours * Convert.ToInt64(nudPower.Value);
                        totalKwh = currentKwh + prevKwh;
                        if (industry == 0)
                        {
                            total = res.Calculate(totalKwh);
                        }
                        else if (industry == 1)
                        {
                            total = com.Calculate(totalKwh);
                        }
                        else if (industry == 2)
                        {
                            total = ind.Calculate(totalKwh, dtpTime.Value);
                        }
                    }
                    string moneyValue = String.Format("{0:C}", (decimal)total);
                    string kwhTrim = totalKwh.ToString("F4");
                    UpdateBill(moneyValue);
                    UpdateKwh(kwhTrim);
                    Thread.Sleep(500);

                    if (_canceller.Token.IsCancellationRequested)
                        break;
                } while (true);
            });
            _canceller.Dispose();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            _canceller.Cancel();
            stopwatch.Stop();
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (btnStop.Enabled)
            {
                _canceller.Cancel();
                stopwatch.Stop();
            }
            stopwatch.Reset();
            nudPower.Value = 0;
            elapsedTime = 0;
            ddlCustomerType.SelectedIndex = 0;
            txtMeter.Text = "0";
            txtKwh.Text = "0";
            industry = 0;
            txtRate.Text = "$" + res.Rate;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DtpTime_ValueChanged(object sender, EventArgs e)
        {
            txtRate.Text = "$" + ind.Rate(dtpTime.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM Customers";
            var c = new SqlConnection(connString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            SqlConnection connection = new SqlConnection(connString);
            string custNoStatement = "SELECT COUNT(AccountNo) AS CustNo FROM Customers;";
            string totalSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers;";
            string totalResSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers WHERE CustomerType = 'R'";
            string totalComSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers WHERE CustomerType = 'C'";
            string totalIndSumStatement = "SELECT SUM(ChargeAmmount) AS ChargeSum FROM Customers WHERE CustomerType = 'I'";
            SqlCommand CustNoCommand = new SqlCommand(custNoStatement, connection);
            SqlCommand TotalSumCommand = new SqlCommand(totalSumStatement, connection);
            SqlCommand TotalResSumCommand = new SqlCommand(totalResSumStatement, connection);
            SqlCommand TotalComSumCommand = new SqlCommand(totalComSumStatement, connection);
            SqlCommand TotalIndSumCommand = new SqlCommand(totalIndSumStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = CustNoCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtCustNo.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
                reader = TotalSumCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtTotSum.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
                reader = TotalResSumCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtResSum.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
                reader = TotalComSumCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtComSum.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
                reader = TotalIndSumCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtIndSum.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            string insertStatement =
                "INSERT INTO Customers "
                + "(CustomerName, CustomerType, ChargeAmmount) "
                + "VALUES (@CustomerName, @CustomerType, @ChargeAmmount)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            char zone;
            if (ddlCustomerType.SelectedIndex == 0)
            {
                zone = 'R';
            }
            else if (ddlCustomerType.SelectedIndex == 1)
            {
                zone = 'C';
            }
            else
            {
                zone = 'I';
            }
            insertCommand.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
            insertCommand.Parameters.AddWithValue("@CustomerType", zone);
            insertCommand.Parameters.AddWithValue("@ChargeAmmount", 0);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                var select = "SELECT * FROM Customers";
                var c = new SqlConnection(connString); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            string deleteStatement =
                "DELETE FROM Customers "
                + "WHERE AccountNO = " + dataGridView1.CurrentRow.Cells["AccountNo"].Value;
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                var select = "SELECT * FROM Customers";
                var c = new SqlConnection(connString); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedZone = Convert.ToChar(dataGridView1.CurrentRow.Cells["CustomerType"].Value);
            if (selectedZone == 'R')
            {
                lblTime.Visible = false;
                dtpTime.Visible = false;
                lblHint.Text = res.Hint;
                txtRate.Text = "$" + res.Rate;
                ddlCustomerType.SelectedIndex = 0;
            }
            else if (selectedZone == 'C')
            {
                lblTime.Visible = false;
                dtpTime.Visible = false;
                lblHint.Text = com.Hint;
                txtRate.Text = "$" + com.Rate;
                ddlCustomerType.SelectedIndex = 1;
            }
            else
            {
                lblTime.Visible = true;
                dtpTime.Visible = true;
                lblHint.Text = ind.Hint;
                txtRate.Text = "$" + ind.Rate(dtpTime.Value);
                ddlCustomerType.SelectedIndex = 2;
            }
        }
    }
}
