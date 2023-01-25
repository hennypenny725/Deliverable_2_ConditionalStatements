/*
Author: Thomas Overholt
Date: 1/24/2023
DescriptionL C# Console Application for calculating letter grades
*/

using System;
using System.Diagnostics.Metrics;

namespace Deliverable_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try 
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: A");
                }

                else if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: B");
                }

                else if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: C");
                }

                else if (grade >= 60 && grade < 70)
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: D");
                }

                else if (grade < 60)
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: F");
                }

            }
            catch
            {
                Console.WriteLine("Did not enter a numeric grade");
            }
           
        }
    }
}