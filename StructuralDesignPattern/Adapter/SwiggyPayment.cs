namespace DesignPatterns
{
    public class SwiggyPayment
    {
        IPaymentAdapter _paymentAdapter;
        public SwiggyPayment(IPaymentAdapter paymentAdapter)
        {
            _paymentAdapter = paymentAdapter;
        }

        public PaymentStatus MakePayment()
        {
            _paymentAdapter.GetLink();
            _paymentAdapter.MakePayment();
            return _paymentAdapter.Status();
        }
    }
}