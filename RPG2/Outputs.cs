using System;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
namespace RPG2
{
    class Outputs
    {
        public static void TextOut(string input) // function for outputting text to console with delay
        {
            int letterDelay = 40;
            int lineDelay = 250;
            int sentenceDelay = 500;
            int commaDelay = 250;
            int count = 0;
            foreach (char x in input)
            {
                Console.Write(x);
                count = ++count;
                Thread.Sleep(letterDelay);
                //if (count == 80)
                //{
                //    Console.WriteLine();
                //    count = 0;
                //}
                if (x.ToString().EndsWith(".") || x.ToString().EndsWith("!") || x.ToString().EndsWith("?"))
                {
                    Thread.Sleep(sentenceDelay);
                }
                else if (x.ToString().EndsWith(","))
                {
                    Thread.Sleep(commaDelay);
                }
            }
            Thread.Sleep(lineDelay);
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ListOptions(string[] options) // list options for selection and wait for input
        {
            foreach (string x in options)
            {
                TextOut(x);
            }

        }

        public static void quickOut(string[] options)
        {
            foreach (string x in options)
            {
                Console.WriteLine(x);
            }
        }
    }
}