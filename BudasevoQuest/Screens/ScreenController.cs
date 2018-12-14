using System;
using System.Threading;
using System.Threading.Tasks;

namespace Screens
{
    public class ScreenController
    {
        Screen activeScreen { get; set; }
        public ScreenController()
        {
        }

        public void SwapScreen(Screen newScreen)
        {
            if (activeScreen != null) newScreen.OnExit();
            activeScreen = newScreen;
            activeScreen.OnEnter();

            new Task(() =>
            {
                while(true)
                {
                    Console.WriteLine("00000");
                    Thread.Sleep(10);
                }
            });
        }
    }
}