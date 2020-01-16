namespace Power_Meter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerTypeLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPower = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nudPower = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtMeter = new System.Windows.Forms.TextBox();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblKwh = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddlCustomerType = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustNo = new System.Windows.Forms.Label();
            this.lblResSum = new System.Windows.Forms.Label();
            this.lblComSum = new System.Windows.Forms.Label();
            this.lblIndSum = new System.Windows.Forms.Label();
            this.lblTotSum = new System.Windows.Forms.Label();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.txtResSum = new System.Windows.Forms.TextBox();
            this.txtComSum = new System.Windows.Forms.TextBox();
            this.txtIndSum = new System.Windows.Forms.TextBox();
            this.txtTotSum = new System.Windows.Forms.TextBox();
            customerTypeLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).BeginInit();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTypeLabel
            // 
            customerTypeLabel.AutoSize = true;
            customerTypeLabel.Location = new System.Drawing.Point(9, 73);
            customerTypeLabel.Name = "customerTypeLabel";
            customerTypeLabel.Size = new System.Drawing.Size(81, 13);
            customerTypeLabel.TabIndex = 22;
            customerTypeLabel.Text = "Customer Type:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(9, 47);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(85, 13);
            customerNameLabel.TabIndex = 23;
            customerNameLabel.Text = "Customer Name:";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(276, 47);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(63, 13);
            this.lblPower.TabIndex = 0;
            this.lblPower.Text = "Power (kW)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(45, 140);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(45, 192);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 192);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // nudPower
            // 
            this.nudPower.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPower.Location = new System.Drawing.Point(356, 44);
            this.nudPower.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nudPower.Name = "nudPower";
            this.nudPower.Size = new System.Drawing.Size(100, 20);
            this.nudPower.TabIndex = 9;
            this.nudPower.ValueChanged += new System.EventHandler(this.NudPower_ValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(150, 140);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // txtMeter
            // 
            this.txtMeter.Location = new System.Drawing.Point(356, 194);
            this.txtMeter.Name = "txtMeter";
            this.txtMeter.ReadOnly = true;
            this.txtMeter.Size = new System.Drawing.Size(100, 20);
            this.txtMeter.TabIndex = 11;
            this.txtMeter.Text = "$0.00";
            // 
            // txtKwh
            // 
            this.txtKwh.Location = new System.Drawing.Point(356, 168);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.ReadOnly = true;
            this.txtKwh.Size = new System.Drawing.Size(100, 20);
            this.txtKwh.TabIndex = 12;
            this.txtKwh.Text = "0";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(356, 90);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(100, 20);
            this.dtpTime.TabIndex = 13;
            this.dtpTime.Visible = false;
            this.dtpTime.ValueChanged += new System.EventHandler(this.DtpTime_ValueChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(356, 142);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 14;
            this.txtRate.Text = "$0.052";
            // 
            // lblKwh
            // 
            this.lblKwh.AutoSize = true;
            this.lblKwh.Location = new System.Drawing.Point(320, 171);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(30, 13);
            this.lblKwh.TabIndex = 15;
            this.lblKwh.Text = "kWh";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(303, 197);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(47, 13);
            this.lblBill.TabIndex = 16;
            this.lblBill.Text = "Bill Total";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(320, 145);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 17;
            this.lblRate.Text = "Rate";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(293, 93);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 13);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Time (24h)";
            this.lblTime.Visible = false;
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.lblInfo);
            this.grbInfo.Location = new System.Drawing.Point(505, 44);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(237, 170);
            this.grbInfo.TabIndex = 20;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Information";
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(26, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(205, 137);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(303, 19);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(114, 13);
            this.lblHint.TabIndex = 21;
            this.lblHint.Text = "Try 1000 for residential";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 269);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // ddlCustomerType
            // 
            this.ddlCustomerType.FormattingEnabled = true;
            this.ddlCustomerType.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.ddlCustomerType.Location = new System.Drawing.Point(126, 70);
            this.ddlCustomerType.Name = "ddlCustomerType";
            this.ddlCustomerType.Size = new System.Drawing.Size(132, 21);
            this.ddlCustomerType.TabIndex = 23;
            this.ddlCustomerType.Text = "Residential";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(126, 44);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(132, 20);
            this.txtCustomerName.TabIndex = 24;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 14);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(108, 23);
            this.btnNewCustomer.TabIndex = 25;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.BtnNewCustomer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Location = new System.Drawing.Point(502, 321);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(108, 13);
            this.lblCustNo.TabIndex = 27;
            this.lblCustNo.Text = "Number of Customers";
            // 
            // lblResSum
            // 
            this.lblResSum.AutoSize = true;
            this.lblResSum.Location = new System.Drawing.Point(502, 347);
            this.lblResSum.Name = "lblResSum";
            this.lblResSum.Size = new System.Drawing.Size(83, 13);
            this.lblResSum.TabIndex = 28;
            this.lblResSum.Text = "Residential Sum";
            // 
            // lblComSum
            // 
            this.lblComSum.AutoSize = true;
            this.lblComSum.Location = new System.Drawing.Point(502, 373);
            this.lblComSum.Name = "lblComSum";
            this.lblComSum.Size = new System.Drawing.Size(85, 13);
            this.lblComSum.TabIndex = 29;
            this.lblComSum.Text = "Commercial Sum";
            // 
            // lblIndSum
            // 
            this.lblIndSum.AutoSize = true;
            this.lblIndSum.Location = new System.Drawing.Point(502, 399);
            this.lblIndSum.Name = "lblIndSum";
            this.lblIndSum.Size = new System.Drawing.Size(73, 13);
            this.lblIndSum.TabIndex = 30;
            this.lblIndSum.Text = "Industiral Sum";
            // 
            // lblTotSum
            // 
            this.lblTotSum.AutoSize = true;
            this.lblTotSum.Location = new System.Drawing.Point(502, 425);
            this.lblTotSum.Name = "lblTotSum";
            this.lblTotSum.Size = new System.Drawing.Size(55, 13);
            this.lblTotSum.TabIndex = 31;
            this.lblTotSum.Text = "Total Sum";
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(616, 318);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.ReadOnly = true;
            this.txtCustNo.Size = new System.Drawing.Size(100, 20);
            this.txtCustNo.TabIndex = 32;
            // 
            // txtResSum
            // 
            this.txtResSum.Location = new System.Drawing.Point(616, 344);
            this.txtResSum.Name = "txtResSum";
            this.txtResSum.ReadOnly = true;
            this.txtResSum.Size = new System.Drawing.Size(100, 20);
            this.txtResSum.TabIndex = 33;
            // 
            // txtComSum
            // 
            this.txtComSum.Location = new System.Drawing.Point(616, 370);
            this.txtComSum.Name = "txtComSum";
            this.txtComSum.ReadOnly = true;
            this.txtComSum.Size = new System.Drawing.Size(100, 20);
            this.txtComSum.TabIndex = 34;
            // 
            // txtIndSum
            // 
            this.txtIndSum.Location = new System.Drawing.Point(616, 396);
            this.txtIndSum.Name = "txtIndSum";
            this.txtIndSum.ReadOnly = true;
            this.txtIndSum.Size = new System.Drawing.Size(100, 20);
            this.txtIndSum.TabIndex = 35;
            // 
            // txtTotSum
            // 
            this.txtTotSum.Location = new System.Drawing.Point(616, 422);
            this.txtTotSum.Name = "txtTotSum";
            this.txtTotSum.ReadOnly = true;
            this.txtTotSum.Size = new System.Drawing.Size(100, 20);
            this.txtTotSum.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(758, 538);
            this.Controls.Add(this.txtTotSum);
            this.Controls.Add(this.txtIndSum);
            this.Controls.Add(this.txtComSum);
            this.Controls.Add(this.txtResSum);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.lblTotSum);
            this.Controls.Add(this.lblIndSum);
            this.Controls.Add(this.lblComSum);
            this.Controls.Add(this.lblResSum);
            this.Controls.Add(this.lblCustNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(customerTypeLabel);
            this.Controls.Add(this.ddlCustomerType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lblKwh);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtKwh);
            this.Controls.Add(this.txtMeter);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.nudPower);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Power Meter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).EndInit();
            this.grbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudPower;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtMeter;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblKwh;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ddlCustomerType;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.Label lblResSum;
        private System.Windows.Forms.Label lblComSum;
        private System.Windows.Forms.Label lblIndSum;
        private System.Windows.Forms.Label lblTotSum;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.TextBox txtResSum;
        private System.Windows.Forms.TextBox txtComSum;
        private System.Windows.Forms.TextBox txtIndSum;
        private System.Windows.Forms.TextBox txtTotSum;
    }
}

