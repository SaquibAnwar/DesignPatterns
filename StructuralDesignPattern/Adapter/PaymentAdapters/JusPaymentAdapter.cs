namespace DesignPatterns
{
    public class JusPayPaymentAdapter : IPaymentAdapter
    {
        JusPayPayment _api = new JusPayPayment();

        public void GetLink()
        {
            _api.MakeLink();
        }

        public void MakePayment()
        {
            _api.MakePayment();
        }

        public PaymentStatus Status()
        {
            
            _api.CheckForSuccess();
            return PaymentStatus.SUCCESS;
        }
    }
}