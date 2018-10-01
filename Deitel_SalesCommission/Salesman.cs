using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deitel_SalesCommission
{
    class Salesman
    {
        //initialize constants, variables, and properties for class Salesman
        public const double BASEPAY = 200;
        public double TotalPay;
        public double WeeklyGrossSales { get; set; }
        public double Commission { get; set; }

        //constructor for Salesman object
        public Salesman(double grossSales)
        {
            CalculateCommission();
            CalculateTotal();
        }

        public double CalculateCommission()
        {
            Commission = WeeklyGrossSales * .09;

            return Commission;
        }

        public double CalculateTotal()
        {
            TotalPay = BASEPAY + Commission;
            return TotalPay;
        }
    }
}
