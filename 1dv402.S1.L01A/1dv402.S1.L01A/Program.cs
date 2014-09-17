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

            // Ange totalsumma (om den är <= 0,49 ska det felhanteras)

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma\t\t: ");
                    subtotal = double.Parse(Console.ReadLine());
                    if (subtotal < 0.5)
                    {
                        throw new SystemException();
                    }
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Du måste ange totalsumman i siffror");
                }
            } 

            // Ange erhållet belopp

            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp\t: ");
                    amountReceived = int.Parse(Console.ReadLine());
                    if (amountReceived < subtotal)
                    {
                        throw new SystemException();
                    }
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Du måste ange ett heltal.");
                }
            }

            // Beräkningar

            total = (int)Math.Round(subtotal);
            roundingOffAmount = total - subtotal;
            change = amountReceived - total;

            // Kvitto

            Console.WriteLine("\nKVITTO");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Totalt\t\t: {0:c2}", subtotal);
            Console.WriteLine("Öresavrundning\t: {0:c2}", roundingOffAmount);
            Console.WriteLine("Att betala\t: {0:c0}", total);
            Console.WriteLine("Kontant\t\t: {0:c0}", amountReceived);
            Console.WriteLine("Tillbaka\t: {0:c0}", change);
            Console.WriteLine("--------------------------");

            // Lämna åter av respektive valuta

            int fivehundreds = 0;
            int onehundreds = 0;
            int fiftyKronors = 0;
            int twentyKronors = 0;
            int tenCrowns = 0;
            int fiveCrowns = 0;
            int oneCrowns = 0;

            fivehundreds = change / 500;
            onehundreds = (change - fivehundreds * 500) % 500 / 100;
            fiftyKronors = (change - fivehundreds * 500 - onehundreds * 100) % 100 / 50;
            twentyKronors = (change - fivehundreds * 500 - onehundreds * 100 - fiftyKronors * 50) % 50 / 20;
            tenCrowns = (change - fivehundreds * 500 - onehundreds * 100 - fiftyKronors * 50 - twentyKronors * 20) % 20 / 10;
            fiveCrowns = (change - fivehundreds * 500 - onehundreds * 100 - fiftyKronors * 50 - twentyKronors * 20 - tenCrowns * 10) % 10 / 5;
            oneCrowns = (change - fivehundreds * 500 - onehundreds * 100 - fiftyKronors * 50 - twentyKronors * 20 - tenCrowns * 10 - fiveCrowns * 5) % 5;

            if (fivehundreds >= 1)
            {
                Console.WriteLine("500-lappar\t: {0}", fivehundreds);
            }

            if (onehundreds >= 1)
            {
                Console.WriteLine("100-lappar\t: {0}", onehundreds);
            }

            if (fiftyKronors >= 1)
            {
                Console.WriteLine("50-lappar\t: {0}", fiftyKronors);
            }

            if (twentyKronors >= 1)
            {
                Console.WriteLine("20-lappar\t: {0}", twentyKronors);
            }

            if (tenCrowns >= 1)
            {
                Console.WriteLine("10-kronor\t: {0}", tenCrowns);
            }

            if (fiveCrowns >= 1)
            {
                Console.WriteLine("5-kronor\t: {0}", fiveCrowns);
            }

            if (oneCrowns >= 1)
            {
                Console.WriteLine("1-kronor\t: {0}", oneCrowns);
            }
        }
    }
}
