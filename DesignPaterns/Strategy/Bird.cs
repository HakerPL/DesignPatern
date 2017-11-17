using DesignPaterns.Strategy.Interface;

namespace DesignPaterns.Strategy
{
    class Bird : Animal
    {
	    public Bird() : base()
        {
	        // We set the Flys interface polymorphically
	        // This sets the behavior as a non-flying Animal

            FlyingType = new ItFly();
        }

        /* BAD
	    * You could override the fly method, but we are breaking
	    * the rule that we need to abstract what is different to
	    * the subclasses
	    *
	    public void fly(){
	        System.out.println("I can fly");
	    }
	    */
    }
}
