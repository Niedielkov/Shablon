using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shablon.Command
{
    public class MakeClassicBurgerCommand : ICommand
    {
        private Chef _chef;

        public MakeClassicBurgerCommand(Chef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            _chef.MakeClassicBurger();
        }
    }
}
