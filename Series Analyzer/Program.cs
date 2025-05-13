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
            //Checks if there are args numbers to use:
            void CheckIfThereAreNumberInArgs()
            {
                List<int> ints = new List<int>();
                foreach (string arg in args)
                {
                    if (int.TryParse(arg, out int num))
                    {
                        ints.Add(int.Parse(arg));
                    }
                    else
                    {
                        InputUserNumber();
                        return;
                    }
                }
                series = ints;
                return;
            }
            // Asks the user for a series of numbers:
            void InputUserNumber()
            { 
            List<int> InputInts = new List<int>();
                Console.WriteLine("Enter a sequence of numbers with a comma separating them: ");
                string[] input  = Console.ReadLine().Split(',');
                foreach (string ipt in input)
                {
                    if (int.TryParse(ipt, out int num)) 
                    {
                        series.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("tre aghin");
                        InputUserNumber();
                    }
                return;                
                } 

            }

            // A function that checks if there are 3 positive numbers in a list
            // and returns all the positive numbers to a new list
            void CheckIfThereAre3PositiveNambers(List<int> _series)
            {
                


                foreach (int number in _series) 
                {
                    if (number > 0)
                    {
                        series.Add(number);
                    }
                }

                if (series.Count < 3)
                {
                    Console.WriteLine("try agein");
                    InputUserNumber() ;
                }
                return ;
            }

                













        }
    }
}
