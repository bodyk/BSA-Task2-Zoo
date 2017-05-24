using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class AddAnimalAction : ZooAction
    {
        public AddAnimalAction()
        {

        }
        public AddAnimalAction(List<Animal> animals) : base(animals)
        {
        }

        public override void Execute()
        {

        }

        public override string GetActionHelp()
        {
            return "Add animal: (name, animal type)";
        }
    }
}
