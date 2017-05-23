using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        public enum State
        {
            SATED,
            HUNGRY,
            SICK,
            DEAD
        }

        public byte Health { get; set; }
        public State StateOfAnimal { get; set; }
        public string Alias { get; set; }
        protected readonly byte MaxHealth;

        public Animal(byte maxHealth)
        {
            MaxHealth = maxHealth;
            StateOfAnimal = State.SATED;
        }

        public void Feed()
        {
            switch (StateOfAnimal)
            {
                case State.HUNGRY:
                    StateOfAnimal = State.SATED;
                    break;
                case State.SICK:
                    StateOfAnimal = State.HUNGRY;
                    break;
                default:
                    break;
            }
        }

        public void Cure()
        {
            if (Health + 1 <= MaxHealth)
                ++Health;
        }
    }
}
