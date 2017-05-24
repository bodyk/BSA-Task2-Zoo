using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class ZooAction: BaseAction
    {
        public List<Animal> Animals { get; set; }
        public ZooAction()
        {

        }
        public ZooAction(List<Animal> animals)
        {
            Animals = animals;
        }
    }
}
