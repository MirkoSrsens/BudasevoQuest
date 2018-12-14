using System;
using System.Collections.Generic;
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
            Console.SetBufferSize(150,50);
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
                            Console.SetWindowSize(windowConfiguration.Width, windowConfiguration.Height);
                            Console.SetBufferSize(windowConfiguration.Width, windowConfiguration.Height);
                            Thread.Sleep(2000);
                        }
                        catch(Exception ex)
                        {

                        }
                    }
                });

            task.Start();

        }
    }
}
