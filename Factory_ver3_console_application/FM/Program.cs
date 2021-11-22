using System;

namespace FM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] samples = {"1/x", "ln(x)", "e^x", "x+2*x^3-5"};
            
            for (int i = 0; i < samples.Length; i++)
            {
                Console.WriteLine("----------------------------------------------------------------");
                
                Console.WriteLine($"Test # {i + 1}\n" +
                                  "| INTEGRATION PROCEDURE |\n" +
                                  $"| f = {samples[i]} |\n" +
                                  $"| F = {new IntegrationCreator().Calculate(samples[i])} |\n");
                
                Console.WriteLine($"Test # {i + 1}\n" +
                                  "| Differentiation PROCEDURE |\n" +
                                  $"| f = {samples[i]} |\n" +
                                  $"| f' = {new DifferentiationCreator().Calculate(samples[i])}|\n");

                Console.WriteLine($"Test # {i + 1}\n" +
                                  "| LIMIT PROCEDURE |\n" +
                                  $"| f = {samples[i]} |\n" +
                                  $"| Lim as x -> +oo = {new LimitCreator().Calculate(samples[i])} |\n");
                
            }
        }
    }
}