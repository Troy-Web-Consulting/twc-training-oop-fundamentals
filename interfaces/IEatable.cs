namespace twc_training_oop_fundamentals.interfaces
{
    public interface IEatable
    {
        int HungerLevel { get; set; }

        void Eat(string food);

        string PreferedFood { get; set; }
    }
}