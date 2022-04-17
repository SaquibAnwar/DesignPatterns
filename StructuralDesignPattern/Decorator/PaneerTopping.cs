namespace DesignPatterns
{
    public class PaneerTopping : IPizza
    {
        IPizza pizza;
        public PaneerTopping(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public string GetComposition()
        {
            return pizza.GetComposition() + " + Paneer Topping";
        }

        public int GetCost()
        {
            return pizza.GetCost() + 100;
        }
    }
}