using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon.Factory
{
    public class ClassicBurger : IBurger
    {
        public string GetDescription()
        {
            return "Classic Burger";
        }
    }
}
