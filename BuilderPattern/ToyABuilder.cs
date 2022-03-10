using System;

namespace DesignPatterns
{
    public class ToyABuilder : IToyBuilder
    {
        private Toy toy;

        public ToyABuilder()
        {
            toy = new Toy();
        }

        public void BuildHead()
        {
            toy.Head = "1";
        }

        public void BuildBody()
        {
            toy.Body = "1";
        }

        public void BuildLegs()
        {
            toy.Legs = "2";
        }

        public void BuildAccessories()
        {
            toy.Accessories = "Accessories A";
        }

        public void BuildToy()
        {
            Console.WriteLine($"Toy A is built with {toy.Head} Head, {toy.Body} Body, {toy.Legs} Legs, and {toy.Accessories} Accesories");
        }

        public Toy GetToy()
        {
            return toy;
        }
    }
}