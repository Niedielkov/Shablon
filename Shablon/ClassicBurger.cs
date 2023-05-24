using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon
{
    public class ClassicBurger : IBurger
    {
        public string GetDescription()
        {
            return "Classic Burger";
        }
    }
}
