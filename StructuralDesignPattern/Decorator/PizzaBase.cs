namespace DesignPatterns
{
    public class PizzaBase : IPizza
    {
        public PizzaBase()
        {
            
        }
        public string GetComposition()
        {
            return "Pizza Base";
        }

        public int GetCost()
        {
            return 50;
        }
    }
}