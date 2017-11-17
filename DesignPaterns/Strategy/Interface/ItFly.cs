namespace DesignPaterns.Strategy.Interface
{
    class ItFly : IFlys
    {
        public string Fly(string className)
        {
            return $"Animal can Fly {className}";
        }
    }
}
