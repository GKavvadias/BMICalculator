using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("-------BMI CALCULATOR-------");
            Console.WriteLine("============================");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Please input your height (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Please input your weight (in kilos): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Your height is {0}: ", height);
            Console.WriteLine("\nYour weight is {0}: ", weight);

            double BMI = weight / Math.Pow(height, 2);
            Math.Round(BMI, 1);

            if (BMI < 18.5)
            {
                Console.WriteLine("\n===============================================");
                Console.WriteLine("Your BMI is " + Math.Round(BMI, 1) + ", is evaluated as \"Underweight\"");
                Console.WriteLine("===============================================");
            }
            else if (BMI >= 18.5 & BMI <= 24.9)
            {
                Console.WriteLine("\n=================================================");
                Console.WriteLine("Your BMI is " + Math.Round(BMI, 1) + ", is evaluated as \"Normal weight\"");
                Console.WriteLine("=================================================");
            }
            else if (BMI >= 25 & BMI <= 29.9)
            {
                Console.WriteLine("\n==============================================");
                Console.WriteLine("Your BMI is " + Math.Round(BMI, 1) + ", is evaluated as \"Overweight\"");
                Console.WriteLine("==============================================");
            }
            else
            {
                Console.WriteLine("\n===========================================");
                Console.WriteLine("Your BMI is " + Math.Round(BMI, 1) + ", is evaluated as \"Obesity\"");
                Console.WriteLine("===========================================");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
