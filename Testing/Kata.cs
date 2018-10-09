using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Testing
{
    public class Kata
    {
        //8 8Kyu Kata Methods
        //https://www.codewars.com/kata/50654ddff44f800200000004
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        //https://www.codewars.com/kata/56dec885c54a926dcd001095
        public int ReverseNum(int a)
        {
            return -a;
        }

        //https://www.codewars.com/kata/583710ccaa6717322c000105
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

        //https://www.codewars.com/kata/53dc23c68a0c93699800041d
        public string SentenceSmash(string[] bleh)
        {
            return string.Join(" ", bleh);
        }

        //https://www.codewars.com/kata/56f6ad906b88de513f000d96
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

        //https://www.codewars.com/kata/55ccdf1512938ce3ac000056
        public bool LochNess(string sentence)
        {
            if (sentence.Contains("tree fiddy") || sentence.Contains("tree Fiddy")
            || sentence.Contains("$3.50")||sentence.Contains("three fifty"))
            {
                return true;
            }
            return false;
        }

        //https://www.codewars.com/kata/544675c6f971f7399a000e79
        public int StringToNumber(string str)
        {
            int number = int.Parse(str);
            return number;
        }

        //https://www.codewars.com/kata/5265326f5fda8eb1160004c8
        public string NumberToString(int num)
        {
            return num.ToString();
        }

        //4 6Kyu Kata Methods
        //https://www.codewars.com/kata/5208f99aee097e6552000148
        public string BreakCamelCase(string str)
        {
            string words = string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                foreach (char ch in str)
                {
                    if (char.IsLower(ch))
                    {
                        words += ch.ToString();
                    }
                    else
                    {
                        words += " " + ch.ToString();
                    }
                }
                return words;
            }
            else
                return string.Empty;
        }

        //https://www.codewars.com/kata/523f5d21c841566fde000009
        public int[] ArrayDiff(int[] a, int[] b)
        {
            int[] c = a.Where(x => !b.Contains(x)).ToArray();
            return c;
        }

        //https://www.codewars.com/kata/514b92a657cdc65150000006
        public int Multiples3or5(int value)
        {
            int currentNumber = value;
            int allSum = 0;
            currentNumber = currentNumber - 1;
            while (currentNumber > 0)
            {
                if (currentNumber % 3 == 0)
                {
                    allSum = allSum + currentNumber;
                }
                else
                {
                    if (currentNumber % 5 == 0)
                    {
                        allSum = allSum + currentNumber;
                    }
                }
                currentNumber = currentNumber - 1;
            }
            return allSum;
        }

        //https://www.codewars.com/kata/stop-gninnips-my-sdrow/solutions/csharp
        public string ReverseWords(string sentence)
        {
            string[] strArr = sentence.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length >= 5)
                {
                    strArr[i] = String.Join("", strArr[i].Reverse());
                }
            }
            return String.Join(" ", strArr);
        }

        //1 5kyu kata
        //https://www.codewars.com/kata/513e08acc600c94f01000001
        public string RGBToHex(int r, int g, int b)
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
