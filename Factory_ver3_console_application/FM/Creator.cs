using AngouriMath;

namespace FM
{
    //Creator class which initializes factory method
    public abstract class Creator
    {
        public abstract Product FactoryMethod();

        public string Calculate(string function)
        {
            var product = FactoryMethod();
            var result = product.Operation(function);
            return result;
        }
    }
}