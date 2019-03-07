using DesignPaterns.Strategy.Interface;

namespace DesignPaterns.Strategy
{
    class StartDesigner
    {
        public static string Start()
        {
            string returnString = "";
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            returnString += sparky.TryToFly();
            returnString += "\n" + tweety.TryToFly();

	        // This allows dynamic changes for flyingType
            sparky.SetFlyingAbility(new ItFly());
            returnString += "\n" + sparky.TryToFly();

            return returnString;
        }
    }
}
