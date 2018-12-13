using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens
{
    class Combat : Screen
    {
        public override void PickOptions()
        {

        }

        public override void ScreenLoad()
        {
            Console.WriteLine("/////////////////////////////////////////////////////////////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////         BUDASEVO MEGA QUEST SHOP                  ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////");
        }

        Combat() : base() { }

    }
}
