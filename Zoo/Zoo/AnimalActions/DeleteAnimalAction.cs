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
        public DeleteAnimalAction(Animal a) : base(a)
        {
        }

        public override void Execute()
        {

        }

        public override string GetActionHelp()
        {
            return "Delete animal: name";
        }
    }
}
