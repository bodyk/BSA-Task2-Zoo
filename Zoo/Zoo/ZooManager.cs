using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Zoo
{
    class ZooManager
    {
        public ZooAction ZooAction { get; set; }
        public List<Animal> AnimalsOfZoo { get; set; }
        public ZooView ConsoleView { get; set; }
        public readonly List<Type> AnimalCreatorTypes;

        private List<AnimalCreator> _creators;

        public ZooManager()
        {
            AnimalsOfZoo = new List<Animal>();
            AnimalCreatorTypes = new List<Type>()
            {
                typeof(BearCreator),
                typeof(ElephantCreator) ,
                typeof(FoxCreator) ,
                typeof(LionCreator) ,
                typeof(TigerCreator) ,
                typeof(WolfCreator)
            };

            ConsoleView = new ZooView(AnimalsOfZoo, AnimalCreatorTypes);

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
            AnimalsOfZoo = ConsoleView.GetOriginAnimals();

            ProccessZooLife();
        }

        private void ProccessZooLife()
        {
            var autoEvent = new AutoResetEvent(false);
            Timer t = new Timer(ZooLoopCallback, autoEvent, 0, 5000);
            autoEvent.WaitOne();
            t.Dispose();
        }

        private void ZooLoopCallback(object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;

            //TODO: Add main zoo logic

            if (AnimalsOfZoo.Count == 0)
            {
                autoEvent.Set();
            }

        }
    }
}
