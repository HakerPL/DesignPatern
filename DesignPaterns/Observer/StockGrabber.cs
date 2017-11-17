using System.Collections.Generic;
using DesignPaterns.Observer.Interface;

namespace DesignPaterns.Observer
{
    class StockGrabber : ISubject
    {
        private readonly List<IObserver> _observersList;
	    private double _ibmPrice;
	    private double _aaplPrice;
	    private double _googPrice;

	    public StockGrabber()
        {
            _observersList = new List<IObserver>();
        }

	    public void Register(IObserver newObserver)
        {
            _observersList.Add(newObserver);
        }

	    public string Unregister(IObserver deleteObserver)
        {
            _observersList.Remove(deleteObserver);

            return $"Observer {deleteObserver.GetObserverId()} deleted";
        }

	    public string NotifyObserver()
	    {
	        string returnString = "";
	        // Cycle through all observers and notifies them of
	        // price changes

            foreach (IObserver observer in _observersList)
                returnString += $"{observer.Update(_ibmPrice, _aaplPrice, _googPrice)}";

	        return returnString;
	    }

	    // Change prices for all stocks and notifies observers of changes
	    public string SetIbmPrice(double newIbmPrice)
        {
            _ibmPrice = newIbmPrice;
            return NotifyObserver();
        }

	    public string SetAaplPrice(double newAaplPrice)
        {
            _aaplPrice = newAaplPrice;
            return NotifyObserver();
        }

	    public string SetGoogPrice(double newGoogPrice)
        {
            _googPrice = newGoogPrice;
            return NotifyObserver();
        }
    }
}
