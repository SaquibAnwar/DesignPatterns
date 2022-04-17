namespace DesignPatterns
{
    public class SauceTopping : IPizza
    {
        IPizza pizza;

        public SauceTopping(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public string GetComposition()
        {
            return pizza.GetComposition() + " + Sauce Topping";
        }

        public int GetCost()
        {
            return pizza.GetCost() + 20;
        }
    }
}