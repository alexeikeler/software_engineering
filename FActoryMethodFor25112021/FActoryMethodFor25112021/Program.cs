using System;
using System.Collections.Generic;

namespace FActoryMethodFor25112021
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] types = { "INTEGRATION", "DIFFERENTIATION", "LIMIT" };

            dict.Add("sin(x+3+2*y)", types[rnd.Next(0, 3)]);
            dict.Add("cos(4*x-1-3*y)", types[rnd.Next(0, 3)]);
            dict.Add("3*x+7-8y+19*x-2", types[rnd.Next(0, 3)]);
            dict.Add("tan(x)+y", types[rnd.Next(0, 3)]);
            dict.Add("4*x+3-12*x-2*y", types[rnd.Next(0, 3)]);

            foreach (KeyValuePair<string, string> typeAndFunc in dict)
            {
                if (FuncTypeChecker(typeAndFunc.Key, "sin", "cos", "tan"))
                {
                    IfTrig(typeAndFunc.Value, typeAndFunc.Key);
                }
                else
                {
                    IfLinear(typeAndFunc.Value, typeAndFunc.Key);
                }

            }

        }

        private static bool FuncTypeChecker(string func, params string[] trigMarkers)
        {
            foreach (string marker in trigMarkers)
            {
                if (func.Contains(marker))
                {
                    return true;
                }
            }

            return false;
        }

        private static void IfTrig(string opType, string fucntion)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"AS TRIGONOMETRIC -> ARG X\n" +
                              $"| {opType} PROCEDURE |\n" +
                              $"| INPUT = {fucntion} |\n" +
                              $"| OUTPUT = {new TrigCreator().FactoryMethod(opType, fucntion)} |\n");
        }

        private static void IfLinear(string opType, string fucntion)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"AS LINEAR -> ARG Y\n" +
                              $"| {opType} PROCEDURE |\n" +
                              $"| INPUT = {fucntion} |\n" +
                              $"| OUTPUT = {new LinearCreator().FactoryMethod(opType, fucntion)} |\n");
        }


    }
}
