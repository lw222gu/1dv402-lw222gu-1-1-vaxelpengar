using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S1.L01A
{
    class Program
    {
        static void Main(string[] args)
        {
            double subtotal = 0;
            int amountReceived = 0;
            int total = 0;
            double roundingOffAmount = 0;
            int change = 0;

            // Ange totalsumma

            Console.Write("Ange totalsumma: ");
            subtotal = double.Parse(Console.ReadLine());

            //while (true)
            //{ 
            //    try
            //    {
                    
            //        sum = double.Parse(sumText);
            //    }

            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Du får enbart ange totalsumman i siffror. Ange totalsumman på nytt: ");
            //    }
            //}

            // Ange erhållet belopp

            Console.Write("Ange erhållet belopp: ");
            amountReceived = int.Parse(Console.ReadLine());

            // Beräkningar

            total = (int)Math.Round(subtotal);
            roundingOffAmount = total - subtotal;
            change = amountReceived - total;

            // Kvitto

            Console.WriteLine("\nKVITTO");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Totalt: {0:c2}", subtotal);
            Console.WriteLine("Öresavrundning: {0:c2}", roundingOffAmount);
            Console.WriteLine("Att betala: {0:c0}", total);
            Console.WriteLine("Kontant: {0:c0}", amountReceived);
            Console.WriteLine("Tillbaka: {0:c0}", change);
            Console.WriteLine("-------------------------");

            // Lämna åter av respektive valuta

            int fivehundreds = 0;
            int onehundreds = 0;
            int fiftyKronors = 0;
            int twentyKronors = 0;
            int tenCrowns = 0;
            int fiveCrowns = 0;
            int oneCrowns = 0;

            fivehundreds = change / 500;
            onehundreds = (change % 500) / 100;
            fiftyKronors = (change % 100) / 50;
            twentyKronors = (change % 50) / 20;
            tenCrowns = (change % 20) / 10;
            fiveCrowns = (change % 10) / 5;
            oneCrowns = (change % 5);

            if (change >= 1)
            {
                    Console.WriteLine("500-lappar: {0}", fivehundreds);
                    Console.WriteLine("100-lappar: {0}", onehundreds);
                    Console.WriteLine("50-lappar: {0}", fiftyKronors);
                    Console.WriteLine("20-lappar: {0}", twentyKronors);
                    Console.WriteLine("10-kronor: {0}", tenCrowns);
                    Console.WriteLine("5-kronor: {0}", fiveCrowns);
                    Console.WriteLine("1-kronor: {0}", oneCrowns);
            }

        }
    }
}
