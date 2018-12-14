using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Settings
{
    public class ProjectSettings
    {
        private readonly WindowConfiguration windowConfiguration;
        public ProjectSettings(WindowConfiguration windowConfiguration)
        {
            this.windowConfiguration = windowConfiguration;
        }

        public void DefineWindow()
        {
            Console.SetWindowSize(windowConfiguration.Width, windowConfiguration.Height);
            Console.SetBufferSize(windowConfiguration.Width, windowConfiguration.Height);
            FixWindowSize();
        }

        private void FixWindowSize()
        {
            var task = new Task(() =>
                {
                    while (true)
                    {
                        try
                        {
                            if (Console.WindowHeight == windowConfiguration.Height && Console.WindowWidth == windowConfiguration.Width) continue;
                            Console.SetCursorPosition(0, 0);
                            Console.SetWindowSize(windowConfiguration.Width, windowConfiguration.Height);
                            Console.SetBufferSize(windowConfiguration.Width, windowConfiguration.Height);
                            Thread.Sleep(2000);
                        }
                        catch (IOException ex) { }
                        catch (ArgumentOutOfRangeException) { }
                    }
                });

            task.Start();

        }
    }
}
