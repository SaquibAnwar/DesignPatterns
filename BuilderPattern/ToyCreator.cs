namespace DesignPatterns
{
    public class ToyCreator
    {
        private IToyBuilder _toyBuilder;

        public ToyCreator(IToyBuilder toyBuilder)
        {
            _toyBuilder = toyBuilder;
        }

        public void BuildToy()
        {
            _toyBuilder.BuildHead();
            _toyBuilder.BuildBody();
            _toyBuilder.BuildLegs();
            _toyBuilder.BuildAccessories();
            _toyBuilder.BuildToy();
        }

        public Toy GetToy()
        {
            return _toyBuilder.GetToy();
        }
    }
}