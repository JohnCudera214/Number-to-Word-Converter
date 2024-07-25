using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Word
{
    internal class Converter
    {
        public static readonly string[] Units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        public static readonly string[] Teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public static readonly string[] Tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public static readonly string[] Thousands = { "", "Thousand", "Million", "Billion" };

        public static string Convert(int number)
        {

            if (number == 0) return "Zero";

            int i = 0;
            string words = "";

            while (number > 0)
            {
                if (number % 1000 != 0)
                {
                    words = Helper(number % 1000) + " " + Thousands[i] + " " + words;
                }
                number /= 1000;
                i++;
            }

            return words.Trim();
        }

        private static string Helper(int number)
        {
            if (number == 0) return "";

            if (number < 10) return Units[number];
            if (number < 20) return Teens[number - 10];
            if (number < 100) return Tens[number / 10] + " " + Helper(number % 10);

            return Units[number / 100] + " Hundred" + (number % 100 > 0 ? " " + Helper(number % 100) : "");
        }
    }
}
