using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zoo
{
    class ZooManager
    {
        public ZooAction ZooAction { get; set; }
        public List<Animal> AnimalsOfZoo { get; set; }
        public ZooView ConsoleView { get; set; }
        public readonly List<Type> AnimalTypes;

        private List<AnimalCreator> _creators;

        public ZooManager()
        {
            AnimalsOfZoo = new List<Animal>();
            AnimalTypes = new List<Type>()
            {
                typeof(BearCreator),
                typeof(ElephantCreator) ,
                typeof(FoxCreator) ,
                typeof(LionCreator) ,
                typeof(TigerCreator) ,
                typeof(WolfCreator)
            };

            ConsoleView = new ZooView(AnimalsOfZoo);

            _creators = new List<AnimalCreator>()
            {
                new BearCreator(),
                new ElephantCreator(),
                new FoxCreator(),
                new LionCreator(),
                new TigerCreator(),
                new WolfCreator()
            };
        }

        public void SetAnimalAction(ZooAction a)
        {
            ZooAction = a;
        }

        public void RunAction()
        {
            ZooAction?.Execute();
        }

        public void OpenZoo()
        {
            ConsoleView.ShowStartHelp();
            while (AnimalsOfZoo.Count == 0)
            {
                ProccessUserInput();
            }
        }

        private void ProccessUserInput()
        {
            List<string> arrUserInput = Console.ReadLine().Split(' ').ToList();

            if (arrUserInput.Count != 0)
            {
                int nCommandNumber = Convert.ToInt32(arrUserInput[0]);

                if (nCommandNumber < AnimalTypes.Count)
                {
                    Animal curAnimal = (Animal)Activator.CreateInstance(AnimalTypes[nCommandNumber]);
                    AnimalsOfZoo.Add(curAnimal);
                }
            }
        }
    }
}
