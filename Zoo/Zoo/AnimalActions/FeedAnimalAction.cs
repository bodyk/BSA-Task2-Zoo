using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class FeedAnimalAction : ZooAction
    {
        public FeedAnimalAction()
        {

        }
        public FeedAnimalAction(Animal a) : base(a)
        {
        }

        public override void Execute()
        {

        }

        public override string GetActionHelp()
        {
            return "Feed animal: (name)";
        }
    }
}
