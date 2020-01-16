using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData
{
    public class Residential
    {
        private double flatRate = 6;
        private double rate = 0.052;

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
            get { return "Try 1000 for residential"; }
        }

        public double Calculate(double totalKwh)
        {
            return flatRate + (rate * totalKwh);
        }
    }
}
