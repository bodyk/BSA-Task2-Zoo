using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class DeleteAnimalAction : ZooAction
    {
        public DeleteAnimalAction()
        {

        }
        public DeleteAnimalAction(List<Animal> animals) : base(animals)
        {
        }

        public override void Execute()
        {

        }

        public override string GetActionHelp()
        {
            return "Delete animal: (name)";
        }
    }
}
