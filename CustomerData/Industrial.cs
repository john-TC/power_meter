using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    public class Industrial
    {
        private double flatRate = 76;

        public double FlatRate
        {
            get { return flatRate; }
        }

        public string Hint
        {
            get { return "Try 1,000,000 for industrial"; }
        }

        public double Rate(DateTime time)
        {
            if (time >= Convert.ToDateTime("15:00:00")
                    && time < Convert.ToDateTime("21:00:00"))
            {
                return 0.065;
            }
            else
            {
                return 0.028;
            }
        }

        public double Calculate(double totalKwh, DateTime time)
        {
            if (totalKwh <= 1000)
            {
                return flatRate;
            }
            else
            {
                return flatRate + (this.Rate(time) * (totalKwh - 1000));
            }
        }
    }
}
