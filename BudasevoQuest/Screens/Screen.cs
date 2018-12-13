﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens
{
    public abstract class Screen
    {
        abstract public void ScreenLoad();
        abstract public void PickOptions();

        protected Screen()
        {
            Console.Clear();
        }
    }
}





