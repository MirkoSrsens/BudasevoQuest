using System;
using System.Collections.Generic;
using System.Text;
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

        public void FixWindowSize()
        {
            var task = new Task(async () => {
                while (true)
                {
                    if (Console.WindowWidth != windowConfiguration.Width)
                    {
                        var kurci = new Action( () =>
                        {
                            Console.SetWindowSize(windowConfiguration.Width, windowConfiguration.Height);
                        });

                        kurci.Invoke();
                    }

                    if (Console.WindowHeight != windowConfiguration.Height)
                    {
                        var kurciPalci = new Action(() =>
                        {
                            Console.SetWindowSize(windowConfiguration.Width, windowConfiguration.Height);
                        });

                        kurciPalci.Invoke();
                    }
                }                
            });

            task.Start();

        }
    }
}
