namespace StOPatterns
{
    public class MaskAtOdd: IMaskType
    {
        public bool Mask(Point position)
        {
            if (position.x + position.y % 2 == 1)
            {
                return true;
            }
            
            return false;
        }
    }
}