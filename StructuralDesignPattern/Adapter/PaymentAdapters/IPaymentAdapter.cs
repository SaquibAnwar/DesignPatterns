namespace DesignPatterns
{
    public enum PaymentStatus
    {
        FAILED,
        SUCCESS,
        WAITING
    }
    public interface IPaymentAdapter
    {
        void GetLink();
        void MakePayment();
        PaymentStatus Status();
    }
}