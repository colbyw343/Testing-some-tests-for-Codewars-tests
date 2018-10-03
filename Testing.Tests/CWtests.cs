using System;
using Xunit;

namespace Testing.Tests
{
    public class CWtests
    {
        //8 of the 8Kyu Kata
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 3, 12)]
        public void Multiply(int a, int b, int expected)
        {
            Kata multiply8 = new Kata();
            int actual = multiply8.Multiply(a, b);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(4,-4)]
        [InlineData(90,-90)]
        [InlineData(-6,6)]
        public void Reverse(int a, int expected)
        {
            Kata reverse8 = new Kata();
            int actual = reverse8.ReverseNum(a);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(2,16)]
        [InlineData(5,45)]
        [InlineData(8,64)]
        public void Times8or9 (int a, int expected)
        {
            Kata times8or9 = new Kata();
            int actual = times8or9.MultiplyBy8or9(a);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(new string[] { "hello", "world", "this", "is", "great" }, "hello world this is great")]
        [InlineData(new string[] { "this","should","work"}, "this should work")]
        public void SentenceSmash(string[] stuff, string expected)
        {
            Kata sentenceSmash8 = new Kata();
            string actual = sentenceSmash8.SentenceSmash(stuff);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(6, true, "$60")]
        [InlineData(7, false, "$7")]
        [InlineData(700, true, "$7000")]
        public void Bonus(int a, bool b, string expected)
        {
            Kata bonus8 = new Kata();
            string actual = bonus8.bonus_time(a,b);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("Tha'll be tree fiddy.",true)]
        [InlineData("Can you spare three fifty?", true)]
        [InlineData("Your total is 5.67.", false)]
        public void LochNess(string sentence, bool expected)
        {
            Kata LochNess8 = new Kata();
            bool actual = LochNess8.LochNess(sentence);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("8",8)]
        [InlineData("76",76)]
        [InlineData("1000",1000)]
        public void StringToNumber(string number1, int number2)
        {
            Kata stringToNumber8 = new Kata();
            int actual = stringToNumber8.StringToNumber(number1);
            Assert.Equal(actual, number2);
        }

        [Theory]
        [InlineData(8,"8")]
        [InlineData(67, "67")]
        [InlineData(1234567890, "1234567890")]
        public void NumberToString(int num, string str)
        {
            Kata numberToString8 = new Kata();
            string actual = numberToString8.NumberToString(num);
            Assert.Equal(actual, str);
        }
    }
}