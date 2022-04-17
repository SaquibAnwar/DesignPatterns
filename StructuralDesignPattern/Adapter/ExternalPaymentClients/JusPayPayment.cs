namespace DesignPatterns
{
    public class JusPayPayment
    {
        public void MakeLink()
        {
            System.Console.WriteLine("This is JusPay payment link");
        }

        public void MakePayment()
        {
            System.Console.WriteLine("Pay JusPay");
        }

        public void CheckForSuccess()
        {
            System.Console.WriteLine("JusPay Success");
        }
    }
}