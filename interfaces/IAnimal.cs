namespace twc_training_oop_fundamentals.interfaces
{
    public interface IAnimal : IEatable
    {
        void MakeNoise();

        string Name { get; set; }

        string Description { get; set; }

        bool IsHumanFriendly { get; set; }
    }
}