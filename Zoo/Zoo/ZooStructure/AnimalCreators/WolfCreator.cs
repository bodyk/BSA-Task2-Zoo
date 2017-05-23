using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.ZooStructure.AnimalCreators
{
    class WolfCreator : AnimalCreator
    {
        public override Animal GetAnimal()
        {
            return new Wolf();
        }
    }
}
