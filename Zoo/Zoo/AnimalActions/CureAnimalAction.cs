using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class CureAnimalAction : ZooAction
    {
        public CureAnimalAction()
        {

        }
        public CureAnimalAction(Animal a) : base(a)
        {
        }

        public override void Execute()
        {

        }

        public override string GetActionHelp()
        {
            return "Cure animal: name";
        }
    }
}
