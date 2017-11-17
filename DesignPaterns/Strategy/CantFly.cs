using DesignPaterns.Strategy.Interface;

namespace DesignPaterns.Strategy
{
    class CantFly : IFlys
    {
        public string Fly(string className)
        {
            return $"Animal can't Fly {className}";
        }
    }
}
