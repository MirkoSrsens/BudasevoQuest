using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;

namespace BudasevoDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameInitializor = new GameInitializor();
            gameInitializor.StartGame();
            Console.ReadKey();
        }
    }
}
