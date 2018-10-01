using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deitel_SalesCommission
{
    class Sales
    {
        //initialize class variables and properties
        static int numberOfSalesman { get; set; }
        static int[] frequency = new int[11];
        static int grossSales;
        static int grossPay;

        static void Main(string[] args)
        {
            //user prompt
            Console.Write("How many salesman will data be entered for? ");
            numberOfSalesman = int.Parse(Console.ReadLine());
            Console.WriteLine();

            InputSalesData();
            OutputResults();

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        static void InputSalesData()
        {
            for (int i = 1; i <= numberOfSalesman; i++)
            {
                //user prompt
                Console.Write("Salesman {0}'s Weekly Gross Sales: ", i);
                grossSales = int.Parse(Console.ReadLine());

                //create a new salesman object
                Salesman salesmani = new Salesman(grossSales);
                grossPay = (int)salesmani.TotalPay;

                //increment the frequency of the earnings bracket for the salesman's gross pay
                if (grossPay >= 200 && grossPay <= 299)
                    ++frequency[2];
                else if (grossPay >= 300 && grossPay <= 399)
                    ++frequency[3];
                else if (grossPay >= 400 && grossPay <= 499)
                    ++frequency[4];
                else if (grossPay >= 500 && grossPay <= 599)
                    ++frequency[5];
                else if (grossPay >= 600 && grossPay <= 699)
                    ++frequency[6];
                else if (grossPay >= 700 && grossPay <= 799)
                    ++frequency[7];
                else if (grossPay >= 800 && grossPay <= 899)
                    ++frequency[8];
                else if (grossPay >= 900 && grossPay <= 999)
                    ++frequency[9];
                else
                    ++frequency[10];
            }

        }
        //output number of employees in each earnings bracket
        static void OutputResults()
        {
            Console.WriteLine("\nEmployees in each earnings bracket:");
            for (int counter = 2; counter < frequency.Length; counter++)
            {
                if (counter < 10)
                    Console.WriteLine("${0}00 - ${0}99: {1, 4}", counter, frequency[counter]);
                else
                    Console.WriteLine("${0}00 - above: {1, 2}\n", counter, frequency[counter]);
            }
        }
    }
}
