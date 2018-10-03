using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class Kata
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int ReverseNum(int a)
        {
            return -a;
        }
        public int MultiplyBy8or9(int a)
        {
            if(a % 2 == 0)
            {
                int c = a * 8;
                return c;
            }
            int d = a * 9;
            return d;
        }
        public string SentenceSmash(string[] bleh)
        {
            return string.Join(" ", bleh);
        }
        public string bonus_time(int salary, bool bonus)
        {
            int salaryPro = salary * 10;
            string salary2 = salaryPro.ToString();
            string salaryString = salary.ToString();
            if (bonus == true)
            {
                return "$" + salary2;
            }
            return "$" + salaryString;
        }
        public bool LochNess(string sentence)
        {
            if (sentence.Contains("tree fiddy") || sentence.Contains("tree Fiddy")
            || sentence.Contains("$3.50")||sentence.Contains("three fifty"))
            {
                return true;
            }
            return false;
        }
        public int StringToNumber(string str)
        {
            int number = int.Parse(str);
            return number;
        }
        public string NumberToString(int num)
        {
            return num.ToString();
        }







        public string RGBToHex(int r, int g, int b)
        {
            {
                if (r > 255)
                {
                    r = 255;
                }
                if (r < 0)
                {
                    r = 0;
                }
                if (g > 255)
                {
                    g = 255;
                }
                if (g < 0)
                {
                    g = 0;
                }
                if (b > 255)
                {
                    b = 255;
                }
                if (b < 0)
                {
                    b = 0;
                }

                string hex = r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
                return hex;

            }
        }
    }
}
