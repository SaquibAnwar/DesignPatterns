namespace DesignPatterns
{
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CardLimit { get; set; }
        public abstract int AnnualCharges { get; set; }
    }
}