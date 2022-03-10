using System;

namespace DesignPatterns
{
    public class ToyBBuilder : IToyBuilder
    {
        private Toy toy;

        public ToyBBuilder()
        {
            toy = new Toy();
        }

        public void BuildHead()
        {
            toy.Head = "7";
        }

        public void BuildBody()
        {
            toy.Body = "1";
        }

        public void BuildLegs()
        {
            toy.Legs = "4";
        }

        public void BuildAccessories()
        {
            toy.Accessories = "Accessories B";
        }

        public void BuildToy()
        {
            Console.WriteLine($"Toy B is built with {toy.Head} Head, {toy.Body} Body, {toy.Legs} Legs, and {toy.Accessories} Accesories");
        }

        public Toy GetToy()
        {
            return toy;
        }
    }
}