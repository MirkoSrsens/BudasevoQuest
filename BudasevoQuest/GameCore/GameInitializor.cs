using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screens;

namespace GameCore
{
    public class GameInitializor
    {
        private MainMenu mainMenu { get; set; }

        public GameInitializor()
        {
            this.mainMenu = new MainMenu();
        }

        public void StartGame()
        {
            Screen.controller.SwapScreen(mainMenu);
        }
    }
}
