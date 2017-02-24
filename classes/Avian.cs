using System;
using twc_training_oop_fundamentals.interfaces;

namespace twc_training_oop_fundamentals.classes
{
    public abstract class Avian : IAnimal, IWalkable, IFlyable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HungerLevel { get; set; }
        public bool IsHumanFriendly { get; set; }
        public string PreferedFood { get; set; }

        // Specific to avians:
        public int Wingspan { get; set; }

        public string FeatherColor { get; set; }

        public virtual void Eat(string food)
        {
            if (HungerLevel > 0)
            {
                Console.WriteLine($"{Name} eats the {food}");
                HungerLevel--;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} ruffles its {Wingspan} inch long {FeatherColor} feathers and flies around!");
            HungerLevel++;
        }

        public abstract void MakeNoise();

        public virtual void Walk()
        {
            Fly();
        }
    }
}