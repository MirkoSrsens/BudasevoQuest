using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameCore.OptionalComponents;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(args[0], out int b))
            {
                GameCore.OptionalComponents.Timer.DurationInSeconds(b);
            }
            Console.ReadKey();
            Environment.Exit(Environment.ExitCode);
        }
    }
}
