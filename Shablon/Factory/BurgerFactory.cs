using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon.Factory
{
    public class BurgerFactory
    {
        public IBurger CreateBurger(string type)
        {
            switch (type)
            {
                case "royal":
                    return new RoyalBurger();
                case "classic":
                    return new ClassicBurger();
                case "veggie":
                    return new VeggieBurger();
                default:
                    throw new ArgumentException("Invalid burger type");
            }
        }
    }
}
