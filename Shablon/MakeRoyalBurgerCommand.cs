using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon
{
    public class MakeRoyalBurgerCommand : ICommand
    {
        private Chef _chef;

        public MakeRoyalBurgerCommand(Chef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            _chef.MakeRoyalBurger();
        }
    }
}
