using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens
{
    class Shop : Screen
    {
        public override void PickOptions()
        {

        }

        public override void ScreenLoad()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("/////////////////////////////////////////////////////////////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////             BUDASEVO MEGA QUEST SHOP              ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////");
        }
    }
}
