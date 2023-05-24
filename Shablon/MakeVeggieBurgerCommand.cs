using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon
{
    public class MakeVeggieBurgerCommand : ICommand
    {
        private Chef _chef;

        public MakeVeggieBurgerCommand(Chef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            _chef.MakeVeggieBurger();
        }
    }
}
