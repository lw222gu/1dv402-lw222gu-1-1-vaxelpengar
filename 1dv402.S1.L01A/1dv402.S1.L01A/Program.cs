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

            // Ange totalsumma (om den är <= 0,49, eller annat än heltal eller flyttal matas in ska det felhanteras)

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma\t\t: ");
                    subtotal = double.Parse(Console.ReadLine());

                    if (subtotal < 0.5)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Beloppet är för litet. Programmet avslutas.");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange totalsumman i siffror");
                    Console.ResetColor();
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
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Beloppet är mindre än totalsumman. Programmet avslutas.");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange ett heltal.");
                    Console.ResetColor();
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
            change = change % 500;
            onehundreds = change / 100;
            change = change % 100;
            fiftyKronors = change / 50;
            change = change % 50;
            twentyKronors = change / 20;
            change = change % 20;
            tenCrowns = change / 10;
            change = change % 10;
            fiveCrowns = change / 5;
            change = change % 5;
            oneCrowns = change / 1;

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
