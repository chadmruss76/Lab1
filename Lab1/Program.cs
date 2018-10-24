using System;
using System.Globalization;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read in three values and store 
            Console.WriteLine("Enter your first value, sucka: ");
            string value1 = Console.ReadLine();
            double currency1;
            currency1 = Convert.ToDouble(value1);

            Console.WriteLine("Enter your second value, sucka: ");
            string value2 = Console.ReadLine();
            double currency2;
            currency2 = Convert.ToDouble(value2);

            Console.WriteLine("Enter your third value, sucka: ");
            string value3 = Console.ReadLine();
            double currency3;
            currency3 = Convert.ToDouble(value3);

            //Compute average
            double ave;
            ave = (currency1 + currency2 + currency3) / 3;
            Console.WriteLine("Average = {0}", ave);

            //Compute min
            if (currency1 < currency2 && currency2 < currency3) 
            {
                Console.WriteLine("Min = {0}", currency1);
            }
            if (currency2 < currency1 && currency2 < currency3)
            {
                Console.WriteLine("Min = {0}", currency2);
            }
            if (currency3 < currency1 && currency3 < currency2)
            {
                Console.WriteLine("Min = {0}", currency3);
            }

            //Compute max
            if (currency1 > currency2 && currency1 > currency3)
            {
                Console.WriteLine("Max = {0}", currency1);
            }
            if (currency2 > currency1 && currency2 > currency3)
            {
                Console.WriteLine("Max = {0}", currency2);
            }
            if (currency3 > currency1 && currency3 > currency2)
            {
                Console.WriteLine("Max = {0}", currency3);
            }

            //Display as currency
            Console.WriteLine(string.Format("{0:c}", ave)); //US

            Console.WriteLine(ave.ToString("C", CultureInfo.CreateSpecificCulture("se-SE"))); //Swedish

            Console.WriteLine(ave.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"))); //Japan

            Console.WriteLine(ave.ToString("C", CultureInfo.CreateSpecificCulture("th-TH"))); //Thai

        }
    }
}
