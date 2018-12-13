using System;
using System.Collections.Generic;
using System.Text;

namespace InputManager
{
    class InputEvent
    {

        public event InputKey InputEventHandler;

        public InputEvent()
        {
            InputEventHandler += ShowKeyEvent;
        }

        public delegate void InputKey(InputData inputData);

        public void ShowKeyEvent(InputData inputData)
        {
            Console.WriteLine(inputData.InputKey);
        }

    }
}
