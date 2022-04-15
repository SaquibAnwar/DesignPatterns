namespace DesignPatterns
{
    public class TitaniumFactory : ICardFactory
    {
        private readonly int _annualCharges;
        private readonly int _cardLimit;
        public TitaniumFactory(int cardLimit, int annualCharges)
        {
            _cardLimit = cardLimit;
            _annualCharges = annualCharges;

        }
        public CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_cardLimit, _annualCharges);
        }
    }
}