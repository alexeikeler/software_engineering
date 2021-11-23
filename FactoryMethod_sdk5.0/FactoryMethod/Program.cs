using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> samples = new List<string>();

            Console.Write("Enter samples: ");
            foreach(string str in Console.ReadLine().Split(" "))
            {
                samples.Add(str);
            }

            foreach(string sample in samples)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine($"Test # 1\n" +
                              "| INTEGRATION PROCEDURE |\n" +
                              $"| f = {sample} |\n" +
                              $"| F = {new IntegrationCreator().Calculate(sample)} |\n");

                Console.WriteLine($"Test # 2\n" +
                                  "| Differentiation PROCEDURE |\n" +
                                  $"| f = {sample} |\n" +
                                  $"| f' = {new DifferentiationCreator().Calculate(sample)}|\n");

                Console.WriteLine($"Test # 3\n" +
                                  "| LIMIT PROCEDURE |\n" +
                                  $"| f = {sample} |\n" +
                                  $"| Lim as x -> +oo = {new LimitCreator().Calculate(sample)} |\n");

            }



        }
    }
}
