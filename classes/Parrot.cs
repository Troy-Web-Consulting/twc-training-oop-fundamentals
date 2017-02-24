using System;
using System.Collections.Generic;
using System.Linq;

namespace twc_training_oop_fundamentals.classes
{
    public class Parrot : Avian
    {
        public Parrot(string name, string featherColor)
        {
            IsHumanFriendly = true;
            PhrasesHeard = new HashSet<string>();
            this.Name = name;
            this.PreferedFood = "seeds";
            Wingspan = 12;
            FeatherColor = featherColor;
            TimesSpoken = 0;
        }

        private ISet<string> PhrasesHeard { get; set; }

        private Random randomizer = new Random();

        private int TimesSpoken { get; set; }

        public void LearnPhrase(string phrase)
        {
            PhrasesHeard.Add(phrase);
        }

        public void Speak()
        {
            if (PhrasesHeard.Count == 0)
            {
                Console.WriteLine($"{Name} looks at you quizzically.");
                return;
            }

            var textToSay = PhrasesHeard.ElementAt(++TimesSpoken % PhrasesHeard.Count);
            Console.WriteLine($"{Name} says: {textToSay}");
        }

        public override void MakeNoise()
        {
            var noiseToMake = randomizer.Next(2);
            if (noiseToMake == 0)
            {
                Console.WriteLine($"{Name} ruffles its feathers");

            }
            else if (noiseToMake == 1)
            {
                Speak();
            }
            else
            {
                Console.WriteLine($"{Name} shrieks!");
            }
        }

        public override void Walk()
        {
            MakeNoise();
            Console.WriteLine($"After that...");
            base.Walk();
        }

        public override void Eat(string food)
        {
            if (food != PreferedFood)
            {
                Console.WriteLine($"{Name} refuses to eat the {food}");
            }
            else
            {
                base.Eat(food);
            }
        }
    }
}