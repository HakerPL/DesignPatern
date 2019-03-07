using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPaterns.AbstractFactory.Interface;

namespace DesignPaterns.AbstractFactory
{
    internal class Coffee : IHotDrink
    {
        private int _amount;

        public Coffee(int amount)
        {
            _amount = amount;
        }

        public string Consume()
        {
            return $"that is Coffee, {nameof(_amount)} = {_amount}";
        }
    }

    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            return new Coffee(amount);
        }
    }
}