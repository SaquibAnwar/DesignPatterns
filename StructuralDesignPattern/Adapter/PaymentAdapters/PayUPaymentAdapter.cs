namespace DesignPatterns
{
    public class PayUPaymentAdapter : IPaymentAdapter
    {
        PayUPayment _api = new PayUPayment();

        public void GetLink()
        {
            _api.MakeLink();
        }

        public void MakePayment()
        {
            _api.Pay();
        }

        public PaymentStatus Status()
        {
            
            _api.SuccessCheck();
            return PaymentStatus.SUCCESS;
        }
    }
}