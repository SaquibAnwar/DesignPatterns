namespace DesignPatterns
{
    public class TitaniumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _cardLimit;
        private int _annualCharges;
        public TitaniumCreditCard(int cardLimit, int annualCharges)
        {
            _cardType = "Titanium";
            _cardLimit = cardLimit;
            _annualCharges = annualCharges;
        }

        public override string CardType 
        {
            get { return _cardType; }
        }

        public override int CardLimit 
        { 
            get { return _cardLimit; } 
            set { _cardLimit = value; }
        }
        public override int AnnualCharges 
        { 
            get { return _annualCharges; } 
            set { _annualCharges = value; } 
        }
    }
}