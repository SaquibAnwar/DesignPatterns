namespace DesignPatterns
{
    public class MoneyBackFactory : ICardFactory
    {
        private readonly int _annualCharges;
        private readonly int _cardLimit;
        public MoneyBackFactory(int cardLimit, int annualCharges)
        {
            _cardLimit = cardLimit;
            _annualCharges = annualCharges;

        }
        public CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_cardLimit, _annualCharges);
        }
    }
}