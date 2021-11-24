using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FActoryMethodFor25112021
{
    public abstract class Product
    {
        public abstract string IntegrationOperation(string function);
        public abstract string DifferentiationOperation(string function);
        public abstract string LimitOperation(string function);

    }
}
