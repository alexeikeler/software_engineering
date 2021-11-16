using System;

namespace StOPatterns
{
    public class MoveAt45: IMoveType
    {
            private int[] directions = {45, 135, 225, 315};
            private int direction;

            public int pick_random()
            {
                var rnd = new Random();
                direction = directions[rnd.Next(0, 3)];
                return direction;
            }
        
            public void Move(int angle, Point position)
            {
                switch (angle)
                {
                    case 45:
                        position.x += 1;
                        position.y += 1;
                        break;
                    
                    case 135:
                        position.x += 1;
                        position.y -= 1;
                        break;
                    
                    case 225:
                        position.x -= 1;
                        position.y += 1;
                        break;
                    
                    case 315:
                        position.x -= 1;
                        position.y -= 1;
                        break;
                }
            }

    }
}