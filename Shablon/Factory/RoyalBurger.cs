using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon.Factory
{
    public class RoyalBurger : IBurger
    {
        public string GetDescription()
        {
            return "Royal Burger";
        }
    }
}
