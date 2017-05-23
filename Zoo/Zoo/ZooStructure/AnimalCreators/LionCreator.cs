using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.ZooStructure.AnimalCreators
{
    class LionCreator: AnimalCreator
    {
        public override Animal GetAnimal()
        {
            return new Lion();
        }
    }
}
