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
            //CheckIfThereAreNumberInArgs();
            //foreach (int ser in series1) { Console.WriteLine(ser); }
            //foreach (int ser in series) { Console.WriteLine(ser); }


                // menu

                void Menu()
                {
                    Console.WriteLine("Select a number from the menu (1-10)");
                    Console.WriteLine("1. Input a Series.");
                    Console.WriteLine("2. Display the series in the order it was entered.");
                    Console.WriteLine("3. Display the series in the reversed order it was\r\nentered.");
                    Console.WriteLine("4. Display the series in sorted order (from low to\r\nhigh).");
                    Console.WriteLine("5. Display the Max value of the series.");
                    Console.WriteLine("6. Display the Min value of the series.");
                    Console.WriteLine("7. Display the Average of the series.");
                    Console.WriteLine("8. Display the Number of elements in the series.");
                    Console.WriteLine("9. Display the Sum of the series.");
                    Console.WriteLine("10. Exit.");
                    Console.WriteLine("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                        {
                        case 1:
                            InputUserNumber();
                            break;
                        case 2:
                            Console.WriteLine("The series you entered: ");
                            foreach (int ser in series1)
                            {
                                Console.WriteLine(ser);
                            }
                            break;
                        case 3:
                            Console.WriteLine("The series you entered in reverse order: ");
                            series1.Reverse();
                            foreach (int ser in series1)
                            {
                                Console.WriteLine(ser);
                            }
                            break;
                        case 4:
                            Console.WriteLine("The series you entered in sorted order: ");
                            series1.Sort();
                            foreach (int ser in series1)
                            {
                                Console.WriteLine(ser);
                            }
                            break;
                        case 5:
                            Console.WriteLine("The max value of the series is: ");
                            Console.WriteLine(series1.Max());
                            break;
                        case 6:
                            Console.WriteLine("The min value of the series is: ");
                            Console.WriteLine(series1.Min());
                            break;

                        case 7:
                            Console.WriteLine("The average of the series is: ");
                            Console.WriteLine(series1.Average());
                            break;
                        case 8:
                            Console.WriteLine("The number of elements in the series is: ");
                            Console.WriteLine(series1.Count());
                            break;
                        case 9:
                            Console.WriteLine("The sum of the series is: ");
                            Console.WriteLine(series1.Sum());
                            break;
                        case 10:
                            Console.WriteLine("Exiting the program...");
                            break;
                        }



                }
                CheckIfThereAreNumberInArgs();
                Menu();





        }

        }
    }

