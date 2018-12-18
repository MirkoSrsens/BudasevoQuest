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
        public void Input()
        {
            var task = new Task( () =>
            {
                while (true)
                {
                    var key = Console.ReadKey().KeyChar;
                    Console.WriteLine("Pressed key is {0}", key);
                }

            });

            task.Start();
        }
    }
}
