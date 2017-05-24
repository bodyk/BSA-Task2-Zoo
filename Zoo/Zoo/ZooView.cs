using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zoo
{
    class ZooView
    {
        private List<Type> animalCreatorTypes;

        public List<Animal> ZooAnimals { get; set; }
        public List<BaseAction> ZooActions { get; set; }

        private const string _inputToStart = "open";
        private const string _sDelimiter = "\n------------\n";
        private const string _sLiveAnimals = "Animals in Zoo:\n";
        public ZooView(List<Animal> animals)
        {
            ZooAnimals = animals;
            ZooActions = new List<BaseAction>() { new AddAnimalAction(), new CureAnimalAction(), new DeleteAnimalAction(), new FeedAnimalAction()};
        }

        public ZooView(List<Animal> animals, List<Type> animalCreatorTypes) : this(animals)
        {
            this.animalCreatorTypes = animalCreatorTypes;
        }

        public void ShowStartHelp()
        {
            string sHelp = $"Add animals to open zoo.\nType '{_inputToStart}' to finish animal initialization and open zoo";
            ShowAnimalTypesInfo();
            Console.WriteLine(sHelp);
            Console.WriteLine(_sDelimiter);
        }

        public void ShowAnimalTypesInfo()
        {
            for (int i = 0; i < animalCreatorTypes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {animalCreatorTypes[i].Name}");
            }
        }

        public void ShowUsualHelp()
        {
            foreach (var action in ZooActions)
            {
                Console.WriteLine(action.GetActionHelp());
            }
        }

        public void ShowInvalidInputError()
        {
            Console.WriteLine("Invalid user input!!!");
        }

        public void ShowLiveAnimals()
        {
            Console.WriteLine(_sLiveAnimals);
            const string sAnimalTemplate = "{0, -10}{1, -20}{2, -10}{3, -10}";
            Console.WriteLine(string.Format(sAnimalTemplate, "Type", "Alias", "Health", "State"));
            Console.WriteLine();
            foreach (Animal animal in ZooAnimals)
            {
                Console.WriteLine(string.Format(sAnimalTemplate, animal.GetType().Name, animal.Alias, animal.Health, animal.StateOfAnimal));
            }
            Console.WriteLine(_sDelimiter);
        }

        public List<Animal> GetOriginAnimals()
        {
            ShowStartHelp();
            string sUserInput = "";
            const int nCurrentParamCount = 2;

            do
            {
                sUserInput = Console.ReadLine();
                Console.Clear();
                ShowStartHelp();
                if (sUserInput.ToLower() == _inputToStart)
                {
                    if (ZooAnimals.Count == 0)
                    {
                        ShowInvalidInputError();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                var arrUserInput = sUserInput.Split(' ');

                if (arrUserInput.Length == nCurrentParamCount)
                {
                    int nCommandNumber = Convert.ToInt32(arrUserInput[0]);
                    Animal curAnimal;

                    if (nCommandNumber <= animalCreatorTypes.Count)
                    {
                        AnimalCreator curAnimalCreator = (AnimalCreator)Activator.CreateInstance(animalCreatorTypes[nCommandNumber - 1]);
                        curAnimal = curAnimalCreator.GetAnimal();
                        curAnimal.Alias = arrUserInput[1];
                        ZooAnimals.Add(curAnimal);

                        ShowLiveAnimals();
                    }
                    else
                    {
                        ShowInvalidInputError();
                    }
                }
                else
                {
                    ShowInvalidInputError();
                }
            } while (true);

            return ZooAnimals;
        }
    }
}
