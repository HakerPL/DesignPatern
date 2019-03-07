using DesignPaterns.Observer.Interface;

namespace DesignPaterns.Observer
{
    class StartDesigner
    {
        public static string Start()
        {
            string returnString = "";
            // Create the ISubject object
            // It will handle updating all observers
            // as well as deleting and adding them
            StockGrabber stockGrabber = new StockGrabber();

            // Create an IObserver that will be sent updates from ISubject
            StockObserver firstObserver = new StockObserver(stockGrabber);

            returnString += $"Register observer {firstObserver.GetObserverId()}\n";

            returnString += $"{stockGrabber.SetIbmPrice(111.00)}";
            returnString += $"{stockGrabber.SetAaplPrice(222.00)}";
            returnString += $"{stockGrabber.SetGoogPrice(333.00)}";

            StockObserver secoundObserver = new StockObserver(stockGrabber);
            returnString += $"Register observer {secoundObserver.GetObserverId()}\n";

            returnString += $"{stockGrabber.SetIbmPrice(444.00)}";
            returnString += $"{stockGrabber.SetAaplPrice(555.00)}";
            returnString += $"{stockGrabber.SetGoogPrice(666.00)}";

            // Delete one of the observers
            returnString += $"{stockGrabber.Unregister(secoundObserver)}\n";

            returnString += $"{stockGrabber.SetIbmPrice(777.00)}";
            returnString += $"{stockGrabber.SetAaplPrice(888.00)}";
            returnString += $"{stockGrabber.SetGoogPrice(999.00)}";

            // Create 3 threads using the Runnable interface
            // GetTheStock implements Runnable, so it doesn't waste
            // its one extendable class option
            //Runnable getIBM = new GetTheStock(stockGrabber, 2, "IBM", 197.00);
            //Runnable getAAPL = new GetTheStock(stockGrabber, 2, "AAPL", 677.60);
            //Runnable getGOOG = new GetTheStock(stockGrabber, 2, "GOOG", 676.40);

            //// Call for the code in run to execute
            //new Thread(getIBM).start();
            //new Thread(getAAPL).start();
            //new Thread(getGOOG).start();

            return returnString;
        }
    }
}
