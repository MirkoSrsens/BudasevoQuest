using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameCore;
using Settings;

namespace BudasevoDungeon
{
    public class Program
    {
        static void Main(string[] args)
        {
            var game = new GameInitializor();

            game.StartGame();

            while(true)
            {
                Thread.Sleep(100000);
            }
        }
    }
}
