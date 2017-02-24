using twc_training_oop_fundamentals.classes;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sashaTheDog = new Dog("Sasha", "Cheagle", "chicken");
            sashaTheDog.MakeNoise();
            sashaTheDog.DoTrick();
            sashaTheDog.DoTrick("Play Dead");
            sashaTheDog.DoTrick("Run Around");

            var polly = new Parrot("Polly", "blue");
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
        }
    }
}
