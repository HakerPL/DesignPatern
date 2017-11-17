using DesignPaterns.Observer.Interface;

namespace DesignPaterns.Observer
{
    class StockObserver : IObserver
    {
        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        // Static used as a counter
        private static int _observerIdTracker;

        // Used to track the observers
        private readonly int _observerId;

        // Will hold reference to the StockGrabber object
        private ISubject _stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {
            // Store the reference to the stockGrabber object so
            // I can make calls to its methods
            _stockGrabber = stockGrabber;

            // Assign an observer ID and increment the static counter
            _observerId = ++_observerIdTracker;

            // Add the observer to the Subjects ArrayList
            _stockGrabber.Register(this);
        }

        public int GetObserverId()
        {
            return _observerId;
        }

        // Called to update all observers
        public string Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            _ibmPrice = ibmPrice;
            _aaplPrice = aaplPrice;
            _googPrice = googPrice;
            return PrintThePrices();
        }

        public string PrintThePrices()
        {
            return $"{_observerId} IBM: {_ibmPrice} AAPL: {_aaplPrice} GOOG: {_googPrice}\n";
        }
    }
}
