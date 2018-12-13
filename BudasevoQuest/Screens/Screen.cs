using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens
{
    public abstract class Screen
    {
        public static ScreenController controller = new ScreenController();

        protected abstract void InitializeScreen();

        internal void OnEnter()
        {
            InitializeScreen();
        }

        internal void OnExit()
        {
            Console.Clear();
        }
    }
}
