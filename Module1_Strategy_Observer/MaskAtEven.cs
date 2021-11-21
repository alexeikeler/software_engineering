namespace StOPatterns
{
    public class MaskAtEven: IMaskType
    {
        public bool Mask(Point position)
        {
            if (position.x + position.y % 2 == 0)
            {
                return true;
            }
            
            return false;
        }
    }
    
}