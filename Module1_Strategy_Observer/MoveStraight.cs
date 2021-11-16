using System;

namespace StOPatterns
{
    public class MoveStraight: IMoveType
    {
        private int[] directions = {0, 90, 180, 270};
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
                case 0:
                    position.y += 1;
                    break;
                case 90:
                    position.x += 1;
                    break;
                case 180:
                    position.y -= 1;
                    break;
                case 270:
                    position.x -= 1;
                    break;
            }
        }
        
    }
}