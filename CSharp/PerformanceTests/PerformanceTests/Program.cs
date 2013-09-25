using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Select from following answers:

//    Write code that uses the Append method of the StringBuilder object
//    Write code that uses the Substring method of the String object
//    Write code that uses the Concat method of the String object
//    Write code that uses the plus-sign (+) operator to concatenate the strings.
namespace PerformanceTests
{
    class Program
    {
        static void Main()
        {
            string first = "FirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirstFirst";
            string second = "SecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecondSecond";
            string third = "ThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThirdThird";
            string result = string.Empty;

            
            StringConcatTest(first, second, third);

            StringConcatTest(first, second, third);
            StringConcatPlusTest(first, second, third);
            StringBuilderTest(first, second, third);
            StringBuilderPlusTest(first, second, third);

        }

        public static void StringConcatTest(string first, string second, string third)
        {
            TimeSpan timeElapsed;
            Stopwatch sw = new Stopwatch();
            string result = string.Empty;

            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                result = string.Concat(result, first, second, third);
            }
            sw.Stop();

            timeElapsed = sw.Elapsed;
            Console.WriteLine("{0} - String.Concat time elapsed -", timeElapsed);
        }
        public static void StringConcatPlusTest(string first, string second, string third)
        {
            TimeSpan timeElapsed;
            Stopwatch sw = new Stopwatch();
            string result = string.Empty;

            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                result = result + first + second + third;
            }
            sw.Stop();

            timeElapsed = sw.Elapsed;
            Console.WriteLine("{0} - String.ConcatPlus time elapsed -", timeElapsed);
        }
            
        public static void StringBuilderTest(string first, string second, string third)
        {
            TimeSpan firstTime;
            Stopwatch sw = new Stopwatch();
            StringBuilder sb = new StringBuilder();

            sw.Start();

            for (int i = 0; i < 100; i++)
            {
                sb.Append(first);
                sb.Append(second);
                sb.Append(third);
            }
            sw.Stop();

            firstTime = sw.Elapsed;
            Console.WriteLine("{0} - StringBuilder time elapsed -", firstTime);
        }
        public static void StringBuilderPlusTest(string first, string second, string third)
        {
            TimeSpan firstTime;
            Stopwatch sw = new Stopwatch();
            StringBuilder sb = new StringBuilder();

            sw.Start();

            for (int i = 0; i < 100; i++)
            {
                sb.Append(first + second + third);
            }
            sw.Stop();

            firstTime = sw.Elapsed;
            Console.WriteLine("{0} - StringBuilderPlus time elapsed -", firstTime);
        }
    }
}
