namespace DesignPatterns
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}