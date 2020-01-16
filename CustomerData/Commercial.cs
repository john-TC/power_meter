using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    public class Commercial
    {
        private double flatRate = 60;
        private double rate = 0.045;

        public double FlatRate
        {
            get { return flatRate; }
        }

        public double Rate
        {
            get { return rate; }
        }

        public string Hint
        {
            get { return "Try 1,000,000 for commercial"; }
        }

        public double Calculate(double totalKwh)
        {
            if (totalKwh <= 1000)
            {
                return flatRate;
            }
            else
            {
                return flatRate + (rate * (totalKwh - 1000));
            }
        }
    }
}
