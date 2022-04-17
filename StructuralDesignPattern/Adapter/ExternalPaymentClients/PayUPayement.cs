namespace DesignPatterns
{
    public class PayUPayment
    {
        public void MakeLink()
        {
            System.Console.WriteLine("This is PayU payment link");
        }

        public void Pay()
        {
            System.Console.WriteLine("Pay PayU");
        }

        public void SuccessCheck()
        {
            System.Console.WriteLine("PayU Success");
        }
    }
}