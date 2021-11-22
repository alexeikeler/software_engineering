using System;

namespace FM
{
    public class ExamplesClass
    {
        private string[] samples = {"1/x", "(x^3+x) / (2+x)", "1/(2^x)"};
        public void Start()
        {
            for (int i = 0; i < samples.Length; i++)
            {
                Console.WriteLine("----------------------------------------------------------------");
                
                Console.WriteLine($"Test # {i + 1} " +
                                   "| INTEGRATION PROCEDURE | " +
                                  $"| f = {samples[i]} | " +
                                  $"| F = {new IntegrationCreator().Calculate(samples[i])} |");
                
                Console.WriteLine($"Test # {i + 1} " +
                                  "| Differentiation PROCEDURE | " +
                                  $"| f = {samples[i]} | " +
                                  $"| f' = {new DifferentiationCreator().Calculate(samples[i])} |");

                Console.WriteLine($"Test # {i + 1} " +
                                  "| LIMIT PROCEDURE | " +
                                  $"| f = {samples[i]} | " +
                                  $"| Lim as x -> +oo = {new LimitCreator().Calculate(samples[i])} |");
                
                Console.WriteLine("----------------------------------------------------------------");

            }
        }
    }
}