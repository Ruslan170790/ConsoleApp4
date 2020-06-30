using System;
using System.Dynamic;
using System.Net.Http.Headers;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double summ = 0;
            double i = 0;
            double n = 0;

            Console.WriteLine("Enter loan amount");//сумма кредита
            summ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter interest rate");// процентная ставка в месяц
            i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years");//количество лет
            n= Convert.ToDouble(Console.ReadLine());

           
                double M = n/12;
                double L = i*(1+i);
                double L1 = (1 + i) - i;
                double y = 0 - M;
                double p = i * L / (1 - System.Math.Pow((1 + L), y));
                double result = summ * (L / L1) * M;

            Console.WriteLine(result);
            Console.ReadLine();
             
          




        }
    }
}
