using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Settings
{
    public class Controls
    {
        private static object Key = new object();

        public void Input()
        {
            var task = new Task( () =>
            {
                lock (Key)
                {
                    while (true)
                    {
                        var key = Console.ReadKey().KeyChar;
                        Console.WriteLine("Pressed key is {0}", key);
                    }
                }
            });

            task.Start();
        }
    }
}
