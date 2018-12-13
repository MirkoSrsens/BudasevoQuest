using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens
{
    class MainMenu : Screen
    {
        public override void PickOptions()
        {
            throw new NotImplementedException();
        }

        public override void ScreenLoad()
        {
            Console.WriteLine("/////////////////////////////////////////////////////////////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////       THIS IS BUDASEVO, YOU CAN'T ESCAPE NOW      ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////              1 - Start Game                       ////////");
            Console.WriteLine("//////              2 - Credits                          ////////");
            Console.WriteLine("//////              3 - Exit                             ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("//////                                                   ////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////////////////////////");
        }

        MainMenu() : base() { }
    }
}
