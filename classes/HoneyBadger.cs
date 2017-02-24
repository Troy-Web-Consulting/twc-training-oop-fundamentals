using System;

namespace twc_training_oop_fundamentals.classes
{
    public class HoneyBadger : Mammal
    {
        public HoneyBadger(string name)
        {
            this.Name = name;
            this.Domesticated = false;

            // Honey badgers don't care about anything.
            this.LevelOfCaring = 0;
        }

        public int LevelOfCaring { get; }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} snarls threateningly!");
        }

        public override void Walk()
        {
            Console.WriteLine($"{Name} starts slowly");
            base.Walk();
            Console.WriteLine($"{Name} starts jogging!");
        }
    }
}