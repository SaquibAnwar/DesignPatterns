namespace DesignPatterns
{
    public class RazorPayPaymentAdapter : IPaymentAdapter
    {
        RazorPayPayment _api = new RazorPayPayment();

        public void GetLink()
        {
            _api.GenerateLink();
        }

        public void MakePayment()
        {
            _api.Payment();
        }

        public PaymentStatus Status()
        {
            _api.SuccessCheck();
            return PaymentStatus.SUCCESS;
        }
    }
}