using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2NumberToWords
{
    public class Numbers

    {
          public static string  Numbers(int number)
        {
            if (number == 0)
                return "zero";

            string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string result = "";

            if (number / 1000 > 0)
            {
                result += units[number / 1000] + "Thousand";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                result += units[number / 100] + "Hundred";
                number %= 100;
            }

            if (number > 0)
            {
                if (result != "")
                    result += "and";

                if (number < 10)
                    result += units[number];
                else if (number < 20)
                    result += teens[number - 10];
                else
                {
                    result += tens[number / 10];
                    if (number % 10 > 0)
                        result += "" + units[number % 10];
                }
            }
        }

    }
}
