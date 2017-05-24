using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class ZooAction
    {
        public Animal CurrentAnimal { get; set; }
        public ZooAction()
        {

        }
        public ZooAction(Animal a)
        {
            CurrentAnimal = a;
        }
        public abstract void Execute();
        public abstract string GetActionHelp();
    }
}
