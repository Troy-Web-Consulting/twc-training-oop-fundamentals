using twc_training_oop_fundamentals.classes;
using twc_training_oop_fundamentals.enums;
using System;

namespace ConsoleApplication
{
    public class Program
    {
        static void Move(string animalName, string animalType)
        {
            // Very procedural, not the best we can do!
            if (animalType == "bird")
            {
                Console.WriteLine($"{animalName} flies.");
            }
            else
            {
                Console.WriteLine($"{animalName} walks forward.");
            }
        }

        public static void Main(string[] args)
        {
            // Old style, procedural code:
            /*
            var animal1Name = "Sasha";
            var animal1Breed = "Cheagle";
            var animal1Type = "dog";
            var animal2Name = "Polly";
            var animal2Breed = (string)null;
            var animal2Type = "bird";
            // etc
            Move(animal1Name, animal1Type);
            Move(animal2Name, animal2Type);

             */

            var sashaTheDog = new Dog("Sasha", "Cheagle", "chicken", Gender.Female);
            sashaTheDog.Eat("kibble");
            sashaTheDog.Eat("chicken");
            sashaTheDog.MakeNoise();
            sashaTheDog.DoTrick();
            sashaTheDog.DoTrick("Play Dead");
            sashaTheDog.DoTrick("Run Around");
            sashaTheDog.Eat("kibble");
            sashaTheDog.Eat("chicken");

            var polly = new Parrot("Patrick", "blue", Gender.Male);
            polly.Eat("Kibble");
            polly.Eat("Steak");
            polly.Eat("seeds");
            polly.Fly();
            polly.Eat("seeds");
            polly.Speak();
            polly.LearnPhrase("want a cracker?");
            polly.Speak();
            polly.LearnPhrase("ARRR MATEY");
            polly.LearnPhrase("Help! I'm trapped in a parrot's body!");
            polly.LearnPhrase("ARRR MATEY");
            polly.Speak();
            polly.Speak();
            polly.Speak();
            polly.Speak();

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
