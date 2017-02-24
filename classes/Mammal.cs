using System;
using twc_training_oop_fundamentals.enums;
using twc_training_oop_fundamentals.interfaces;

namespace twc_training_oop_fundamentals.classes
{
    public abstract class Mammal : IAnimal, IWalkable, IGenderable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HungerLevel { get; set; }
        public bool IsHumanFriendly { get; set; }
        public string PreferedFood { get; set; }
        public Gender Gender { get; set; }

        // Mammal Specific Stuff
        public string HairColor { get; set; }

        public string NumberOfLegs { get; set; }

        public bool Domesticated { get; set; }

        public virtual void Eat(string food)
        {
            if (HungerLevel > 0)
            {
                Console.WriteLine($"{Name} eats the {food}");
                HungerLevel--;
            }
        }

        public abstract void MakeNoise();

        public virtual void Walk()
        {
            Console.WriteLine($"{Name} walks forward at a leisurely pace");
        }

        public Mammal(Gender gender)
        {
            this.Gender = gender;
        }
    }
}
