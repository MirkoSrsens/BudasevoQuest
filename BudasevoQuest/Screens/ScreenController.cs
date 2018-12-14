namespace Screens
{
    public class ScreenController
    {
        Screen activeScreen { get; set; }
        public ScreenController()
        {
        }

        public void SwapScreen(Screen newScreen)
        {
            if (activeScreen != null) activeScreen.OnExit();
            activeScreen = newScreen;
            activeScreen.OnEnter();
        }
    }
}