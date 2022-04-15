namespace DesignPatterns
{
    public class PlatinumFactory : ICardFactory
    {
        private readonly int _annualCharges;
        private readonly int _cardLimit;
        public PlatinumFactory(int cardLimit, int annualCharges)
        {
            _cardLimit = cardLimit;
            _annualCharges = annualCharges;

        }
        public CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_cardLimit, _annualCharges);
        }
    }
}