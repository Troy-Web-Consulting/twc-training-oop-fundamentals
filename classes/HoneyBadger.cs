using System;
using twc_training_oop_fundamentals.enums;

namespace twc_training_oop_fundamentals.classes
{
    public class HoneyBadger : Mammal
    {
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
        
        public HoneyBadger(string name, Gender gender) : base(gender)
        {
            this.Name = name;
            this.Domesticated = false;

            // Honey badgers don't care about anything.
            this.LevelOfCaring = 0;
        }

        public int LevelOfCaring { get; }
    }
}