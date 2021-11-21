using System;

namespace StOPatterns
{
    public class Frontiers : IObserver
    {
        private string type;
        public Frontiers(string type)
        {
            this.type = type;
        }
        public void Update(Point currentPoint, bool isMasked)
        {
            switch (type)
            {
                case "topLeft":
                    if (currentPoint.x < 3 && currentPoint.x >= 0
                                           && currentPoint.y < 3 && currentPoint.y >= 0 && isMasked == false)
                    {
                        Console.WriteLine("Spy got caught at top left corner of the field.");
                        Environment.Exit(0);
                    }
                    break;
                
                case "topRight":
                    if (currentPoint.x > 6 && currentPoint.x < 10
                                           && currentPoint.y < 3 && currentPoint.y >= 0 && isMasked == false)
                    {
                        Console.WriteLine("Spy got caught at top right corner of the field.");
                        Environment.Exit(0);
                    }

                    break;
                
                case "bottomLeft":
                    if (currentPoint.x < 3 && currentPoint.x >= 0 
                                           && currentPoint.y < 6 && currentPoint.y < 10 && isMasked == false)
                    {
                        Console.WriteLine("Spy got caught at bottom left corner of the field.");
                        Environment.Exit(0);
                    }

                    break;
                
                case "bottomRight":
                    if (currentPoint.x > 6 && currentPoint.x < 10
                                           && currentPoint.y > 6 && currentPoint.y < 10 && isMasked == false) 
                    {
                        Console.WriteLine("Spy got caught at bottom right corner of the field.");
                        Environment.Exit(0);
                    }

                    break;
                    
            }

            if (currentPoint.y > 2 && currentPoint.y < 7
                                   && currentPoint.x < 0 || currentPoint.x > 9 )
            {
                Console.WriteLine("Spy escaped.");
                Environment.Exit(0);
            }
            
            else if (currentPoint.x > 2 && currentPoint.x < 7
                                        && currentPoint.y < 0 || currentPoint.y > 9)
            {
                Console.WriteLine("Spy escaped.");
                Environment.Exit(0);
            }


        }

    }
}