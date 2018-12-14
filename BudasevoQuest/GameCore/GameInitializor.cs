﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screens;
using Settings;

namespace GameCore
{
    public class GameInitializor
    {

        private MainMenu mainMenu { get; set; }
        private CombatScreen combatScreen { get; set; }
        private ProjectSettings projectSettings { get; set; }
        private WindowConfiguration windowConfiguration { get; set; }

        public GameInitializor()
        {
            windowConfiguration = new WindowConfiguration()
            {
                Height = 30,
                Width = 90
            };

            this.projectSettings = new ProjectSettings(windowConfiguration);
            this.mainMenu = new MainMenu();
            this.combatScreen = new CombatScreen();
        }

        public void StartGame()
        {
            projectSettings.DefineWindow();

            Screen.controller.SwapScreen(mainMenu);
            Console.ReadKey();
            Screen.controller.SwapScreen(combatScreen);
        }
    }
}
