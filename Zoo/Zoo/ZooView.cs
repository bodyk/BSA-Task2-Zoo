using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class ZooView
    {
        public List<Animal> ZooAnimals { get; set; }
        public List<ZooAction> ZooActions { get; set; }
        public ZooView(List<Animal> animals)
        {
            ZooAnimals = animals;
            ZooActions = new List<ZooAction>() { new AddAnimalAction(), new CureAnimalAction(), new DeleteAnimalAction(), new FeedAnimalAction()};
        }

        public void ShowStartHelp()
        {
            string sHelp = "Add animal to open zoo.\n";
            sHelp += "At least one animal must be.";
            Console.WriteLine(sHelp);
            ShowUsualHelp();
        }

        public void ShowUsualHelp()
        {
            foreach (var action in ZooActions)
            {
                Console.WriteLine(action.GetActionHelp());
            }
        }

        public void ShowInvalidError()
        {
            Console.WriteLine("Invalid user input!!!");
        }
    }
}
