namespace DesignPatterns
{
    public class CheezeTopping : IPizza
    {
        IPizza pizza;

        public CheezeTopping(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public string GetComposition()
        {
            return pizza.GetComposition() + " + Cheeze Topping";
        }

        public int GetCost()
        {
            return pizza.GetCost() + 50;
        }
    }
}