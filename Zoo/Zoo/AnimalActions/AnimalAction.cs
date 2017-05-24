using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class AnimalAction: BaseAction
    {
        public Animal CurrentAnimal { get; set; }
        public AnimalAction()
        {

        }
        public AnimalAction(Animal a)
        {
            CurrentAnimal = a;
        }
    }
}
