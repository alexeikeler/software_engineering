using System;
using System.Threading;
using AngouriMath;

namespace Singleton
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Singleton forDifferentiation = Singleton.getInstance;
           
            Thread myThread = new Thread(new ThreadStart(IntegralEval));
            myThread.Start();
            
            var rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In parent thread");
                forDifferentiation.Differentiate(rnd.Next(1, 10));
                Thread.Sleep(400);
            }

            
        }

        private static void IntegralEval()
        {
            var rnd = new Random();
            
            Singleton forIntegration = Singleton.getInstance;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In child thread");
                forIntegration.Integrate(rnd.Next(1, 10), rnd.Next(1, 10));
                Thread.Sleep(300);
            }

        }
    }
}