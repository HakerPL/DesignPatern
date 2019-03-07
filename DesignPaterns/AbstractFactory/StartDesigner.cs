using DesignPaterns.AbstractFactory.Interface;

namespace DesignPaterns.AbstractFactory
{
    public class StartDesigner
    {
        public static string Start()
        {
            HotDrinkMachineOnEnum drinkMachineOnEnum = new HotDrinkMachineOnEnum();

            string returnString = "HotDrinkMachineOnEnum \n";

            returnString += "Create Tea 50 \n";
            IHotDrink tea50 = drinkMachineOnEnum.MakeDrink(HotDrinkMachineOnEnum.AvailableDrinkType.Tea, 50);
            returnString += tea50.Consume() + "\n\n";

            returnString += "Create Coffee 80 \n";
            IHotDrink coffee80 = drinkMachineOnEnum.MakeDrink(HotDrinkMachineOnEnum.AvailableDrinkType.Coffee, 80);
            returnString += coffee80.Consume() + "\n\n";

            returnString += "Create Tea 1 \n";
            IHotDrink tea1 = drinkMachineOnEnum.MakeDrink(HotDrinkMachineOnEnum.AvailableDrinkType.Tea, 1);
            returnString += tea1.Consume() + "\n\n";

            returnString += "Create Coffee 2 \n";
            IHotDrink coffee2 = drinkMachineOnEnum.MakeDrink(HotDrinkMachineOnEnum.AvailableDrinkType.Coffee, 2);
            returnString += coffee2.Consume() + "\n";


            returnString += "\nHotDrinkMachineReflection \n";

            HotDrinkMachineReflection drinkMachineReflection = new HotDrinkMachineReflection();

            returnString += "Create Tea 40 \n";
            IHotDrink tea40 = drinkMachineReflection.MakeDrink("Tea", 40);
            returnString += tea40.Consume() + "\n\n";

            returnString += "Create Coffee 77 \n";
            IHotDrink coffee77 = drinkMachineReflection.MakeDrink("Coffee", 77);
            returnString += coffee77.Consume() + "\n\n";

            returnString += "Create Tea 4 \n";
            IHotDrink tea4 = drinkMachineReflection.MakeDrink("Tea", 4);
            returnString += tea4.Consume() + "\n\n";

            returnString += "Create Coffee 6 \n";
            IHotDrink coffee6 = drinkMachineReflection.MakeDrink("Coffee", 6);
            returnString += coffee6.Consume() + "\n";


            return returnString;
        }
    }
}
