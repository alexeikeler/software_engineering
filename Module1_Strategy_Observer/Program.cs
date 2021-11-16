using System;
using System.IO;

namespace StOPatterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            Spy sp = new Spy();
            Random rnd = new Random();
            
            Frontiers topLeft = new Frontiers("topLeft");
            Frontiers topRight = new Frontiers("topRight");
            Frontiers bottomLeft = new Frontiers("bottomLeft");
            Frontiers bottomRight = new Frontiers("bottomRight");

            sp.AddObserver(topLeft);
            sp.AddObserver(topRight);
            sp.AddObserver(bottomLeft);
            sp.AddObserver(bottomRight);

            
            while (true)
            {
                sp.MoveHow(rnd.Next(0, 20));
            }
        }
    }
}