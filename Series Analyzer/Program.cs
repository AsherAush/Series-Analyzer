using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> series = new List<int>();
            List<int> series1 = new List<int>();
            //Checks if there are args numbers to use:
            void CheckIfThereAreNumberInArgs()
            {
                List<int> ints = new List<int>();
                foreach (string arg in args)
                {
                    if (int.TryParse(arg, out int num))
                    {
                        ints.Add((num));
                    }
                    else
                    {
                        InputUserNumber();
                        return;
                    }
                }
                CheckIfThereAre3PositiveNambers(series);
                series = ints;
                return;
            }
            // Asks the user for a series of numbers:
            void InputUserNumber()
            { 
            List<int> InputInts = new List<int>();
                Console.WriteLine("Enter a sequence of numbers with a comma separating them: ");
                string[] input  = Console.ReadLine().Split(',');
                List<int> ints = new List<int>();
                

                if (input.Length < 3) 
                {
                    Console.WriteLine("rty aghein2");
                    InputUserNumber();
                }
                else
                {

                    foreach (string ipt in input)
                    {
                   

                        if (int.TryParse(ipt, out int num))
                        {
                            series.Add(num);
                        }
                        else
                        {
                            series = null;
                            Console.WriteLine("tre aghin");
                            InputUserNumber();
                        }
                    }
                    CheckIfThereAre3PositiveNambers(series);
                    return;
                }

            }

            // A function that checks if there are 3 positive numbers in a list
            // and returns all the positive numbers to a new list
            void CheckIfThereAre3PositiveNambers(List<int> _series)
            {
                


                List<int> ints = new List<int>();
                foreach (int number in _series) 
                {
                    if (number > 0)
                    {
                        series1.Add(number);
                    }
                }

                if (series1.Count < 3)
                {
                    ints = null;
                    Console.WriteLine("try agein1");
                    InputUserNumber() ;
                }
                return ;
            }
            CheckIfThereAreNumberInArgs();
            foreach (int ser in series1) { Console.WriteLine(ser); }
            //foreach (int ser in series) { Console.WriteLine(ser); }


                













        }
    }
}
