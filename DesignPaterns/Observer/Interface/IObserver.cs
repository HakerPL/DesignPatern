namespace DesignPaterns.Observer.Interface
{
    internal interface IObserver
    {
        string Update(double ibmPrice, double aaplPrice, double googPrice);
        int GetObserverId();
    }
}
