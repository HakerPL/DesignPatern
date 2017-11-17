namespace DesignPaterns.Observer.Interface
{
    internal interface ISubject
    {
        void Register(IObserver observer);
        string Unregister(IObserver observer);
	    string NotifyObserver();
    }
}
