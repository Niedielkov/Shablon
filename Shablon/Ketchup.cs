using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon
{
    public class Ketchup : BurgerDecorator
    {
        public Ketchup(IBurger burger) : base(burger) { }

        public override string GetDescription()
        {
            return _burger.GetDescription() + " with ketchup";
        }
    }
}
