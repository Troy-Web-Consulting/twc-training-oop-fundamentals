using System;
using twc_training_oop_fundamentals.enums;

namespace twc_training_oop_fundamentals.classes
{
    public class Dog : Mammal
    {
        // It already has all the properties from its parent class, Mammal
        public Dog(string name, string breed, string favoriteFood, Gender gender) : base(gender)
        {
            this.Name = name;
            this.Breed = breed;
            this.Domesticated = true;

            this.PreferedFood = favoriteFood;
            this.Description = $"{Name} is a {breed} and loves to eat {favoriteFood}";
        }

        public override void Eat(string food)
        {
            if (HungerLevel > 3)
            {
                // Eat like normal because dog is hungry
                base.Eat(food);
            }
            else if (HungerLevel <= 3 && HungerLevel > 0 && food == PreferedFood)
            {
                // U
                base.Eat(food);
                Console.WriteLine($"{Name} looks a little sick from eating too much");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry enough to eat {food}");
            }
        }

        public string Breed { get; set; }

        public void DoTrick()
        {
            DoTrick("Give Paw");
        }

        public void DoTrick(string trick)
        {
            if (trick == "Play Dead")
            {
                Console.WriteLine($"{Name} played dead!");
            }
            else if (trick == "Give Paw")
            {
                Console.WriteLine($"{Name} gave paw!");
            }
            else
            {
                Console.WriteLine($"{Name} does not know how to {trick}; instead, {Name} gave paw.");
            }

            HungerLevel++;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("WOOF! WOOF! BARKBARKBARK! WOOF!");
        }
    }
}