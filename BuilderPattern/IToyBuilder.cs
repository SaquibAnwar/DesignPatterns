namespace DesignPatterns
{
    public interface IToyBuilder
    {
        void BuildHead();
        void BuildBody();
        void BuildLegs();
        void BuildAccessories();
        void BuildToy();
        Toy GetToy();
    }
}