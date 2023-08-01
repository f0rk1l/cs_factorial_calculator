using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter number: ");
                    double number = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nChoose factorial type:\n\n[1] Factorial\n\n[2] Double factorial\n\n[3] Primorial\n\n[4] Super factorial\n\n[5] Fibonarial\n\nChoose: ");
                    int Choose = Convert.ToInt32(Console.ReadLine());


                    switch (Choose)
                    {
                        case 1:

                            Console.WriteLine($"\n\nFactorial of {number}: {FactorialCalculator.Factorial(number)}");

                            break;

                        case 2:

                            Console.WriteLine($"\n\nDouble factorial of {number}: {FactorialCalculator.DoubleFactorial(number)}");

                            break;

                        case 3:

                            Console.WriteLine($"\n\nPrimorial of {number}: {FactorialCalculator.Primorial(number)}");

                            break;

                        case 4:

                            Console.WriteLine($"\n\nSuper factorial of {number}: {FactorialCalculator.SuperFactorial(number)}");

                            break;

                        case 5:

                            Console.WriteLine($"\n\nFibonarial of {number}: {FactorialCalculator.Fibonarial(number)}");

                            break;

                        default:

                            Console.WriteLine("\n\nIncorrect choose!");

                            break;
                    }

                } 
                
                catch(FormatException ex)
                {
                    Console.WriteLine("\n\nIncorrect input!");
                }

                Console.Write("\n\nPress some button to clear output...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
