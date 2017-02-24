namespace twc_training_oop_fundamentals.interfaces
{
    public interface IAnimal : IEatable, IGenderable
    {
        void MakeNoise();

        string Name { get; set; }

        string Description { get; set; }

        bool IsHumanFriendly { get; set; }
    }
}