using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon
{
    public class Restaurant
    {
        private static Restaurant instance;
        private static readonly object lockObject = new object();

        private Restaurant() { }

        public static Restaurant GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    instance = new Restaurant();
                }
            }

            return instance;
        }
    }
}
