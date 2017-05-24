using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class BaseAction
    {
        public BaseAction()
        {

        }
        public abstract void Execute();
        public abstract string GetActionHelp();
    }
}
