using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.ZooStructure.AnimalCreators
{
    class ElephantCreator : AnimalCreator
    {
        public override Animal GetAnimal()
        {
            return new Elephant();
        }
    }
}
