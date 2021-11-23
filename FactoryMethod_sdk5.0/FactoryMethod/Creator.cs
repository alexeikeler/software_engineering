using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
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
