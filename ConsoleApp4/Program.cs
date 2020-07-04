using System;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Transactions;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Enter loan amount");//сумма кредита
            double summ= Convert.ToDouble(Console.ReadLine());
          

            Console.WriteLine("Enter interest rate");// процентная ставка годовых
            double i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years");//количество лет
            double n = Convert.ToDouble(Console.ReadLine());
            
            double months = n * 12;
            i = i / 12;// ПРОЦЕНТНАЯ СТАВКА В МЕСЯЦ
            i = i / 100;// ПРОЦЕНТЫ
            double Loan = i * System.Math.Pow((1 + i),months) ;
            double Loan1 = System.Math.Pow((1 + i), months) - 1;
            double L = Loan / Loan1;
            double result = summ * L;
            Console.WriteLine(result);

            DateTime dtt = new DateTime(2020, 07, 01);
            for (int d = 0; d < months; d++) 
            {
               var date = dtt.ToString("d", DateTimeFormatInfo.InvariantInfo);

                Console.WriteLine($"{date}, {result.ToString("C")}");
                dtt=dtt.AddMonths(1);
            }
            








        }
    }
}
