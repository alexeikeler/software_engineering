using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngouriMath;

namespace FactoryMethod
{
    //Concrete creator # 1 - integration creator returns integration product
    public class IntegrationCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new IntegrationProduct();
        }
    }

    //Concrete product # 1 - integration product returns integration result
    public class IntegrationProduct : Product
    {
        public override string Operation(string function)
        {
            Entity angMathFIntegration = function;
            return angMathFIntegration.Integrate("x").InnerSimplified.ToString();

        }
    }

    //Concrete creator # 2 - differentiation creator - returns differentiation product
    public class DifferentiationCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new DifferentiationProduct();
        }
    }

    //Concrete product # 2 - differentiation product - returns differentiation result
    public class DifferentiationProduct : Product
    {
        public override string Operation(string function)
        {
            Entity angMathFDifferentiation = function;
            return angMathFDifferentiation.Differentiate("x").InnerSimplified.ToString();
        }
    }


    //Concrete creator # 3 - limit creator - returns limit product
    public class LimitCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new LimitProduct();
        }
    }

    //Concrete product # 3 - limit product - returns limit result
    public class LimitProduct : Product
    {
        public override string Operation(string function)
        {
            Entity angMathFLimit = function;
            return angMathFLimit.Limit("x", "+oo").InnerSimplified.ToString();
        }
    }
}

