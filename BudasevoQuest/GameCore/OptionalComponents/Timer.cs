using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameCore.OptionalComponents
{
    public class Timer
    {
        public static void DurationInSeconds(int numberOfSeconds)
        {

            var actionTiming = new Action<int>(a =>
            {
                while (a > 0)
                {
                    a--;
                    var outPutText = string.Format("Time left: {0}", a);
                    Console.WriteLine(outPutText);
                    Thread.Sleep(1000);
                }
            });


            var thread = new Thread(() =>
            {
                actionTiming(numberOfSeconds);
            });

            thread.Start();
        }
    }
}
