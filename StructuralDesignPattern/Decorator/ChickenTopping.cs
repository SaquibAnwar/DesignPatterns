namespace DesignPatterns
{
    public class ChickenTopping : IPizza
    {
        IPizza pizza;

        public ChickenTopping(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public string GetComposition()
        {
            return pizza.GetComposition() + " + Chicken Topping";
        }

        public int GetCost()
        {
            return pizza.GetCost() + 150;
        }
    }
}