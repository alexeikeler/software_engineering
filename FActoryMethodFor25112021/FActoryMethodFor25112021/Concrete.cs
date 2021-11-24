using AngouriMath;

namespace FActoryMethodFor25112021
{
    public class TrigCreator : Creator
    {
        public override string FactoryMethod(string opType, string function)
        {
            switch (opType)
            {
                case "INTEGRATION":
                    return new TrigProduct().IntegrationOperation(function);
                case "DIFFERENTIATION":
                    return new TrigProduct().DifferentiationOperation(function);
                case "LIMIT":
                    return new TrigProduct().LimitOperation(function);
            }
            return "Error in SinCreator FM";
        }
    }


    public class LinearCreator : Creator
    {
        public override string FactoryMethod(string opType, string function)
        {
            switch (opType)
            {
                case "INTEGRATION":
                    return new LinearProduct().IntegrationOperation(function);
                case "DIFFERENTIATION":
                    return new LinearProduct().DifferentiationOperation(function);
                case "LIMIT":
                    return new LinearProduct().LimitOperation(function);
            }
            return "Error in FactoryMethod of LinearCreator";
        }
    }


    public class TrigProduct : Product
    {
        public override string IntegrationOperation(string function)
        {

            Entity angMathFIntegration = function;
            return angMathFIntegration.Integrate("x").InnerSimplified.ToString();
        }

        public override string DifferentiationOperation(string function)
        {

            Entity angMathFDifferentiation = function;
            return angMathFDifferentiation.Differentiate("x").InnerSimplified.ToString();
        }

        public override string LimitOperation(string function)
        {
            Entity angMathFLimit = function;
            return angMathFLimit.Limit("x", "0").InnerSimplified.ToString();

        }

    }

    public class LinearProduct : Product
    {
        public override string IntegrationOperation(string function)
        {

            Entity angMathFIntegration = function;
            return angMathFIntegration.Integrate("y").InnerSimplified.ToString();
        }

        public override string DifferentiationOperation(string function)
        {

            Entity angMathFDifferentiation = function;
            return angMathFDifferentiation.Differentiate("y").InnerSimplified.ToString();
        }

        public override string LimitOperation(string function)
        {
            Entity angMathFLimit = function;
            return angMathFLimit.Limit("y", "+oo").InnerSimplified.ToString();

        }

    }


}
