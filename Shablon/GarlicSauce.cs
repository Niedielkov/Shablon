using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon
{
    public class GarlicSauce : BurgerDecorator
    {
        public GarlicSauce(IBurger burger) : base(burger) { }

        public override string GetDescription()
        {
            return _burger.GetDescription() + " with garlic sauce";
        }
    }
}
