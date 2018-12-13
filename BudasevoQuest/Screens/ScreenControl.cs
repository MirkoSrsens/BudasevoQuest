using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens
{
    public class ScreenControl
    {
        public Screen activeScreen;

        public void SwapScreen(Screen newScreen)
        {
            activeScreen.OnExit();
            activeScreen = newScreen;
            newScreen.OnEnter();
        }
    }
}
