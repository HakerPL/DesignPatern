using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPaterns.AbstractFactory.Interface;

namespace DesignPaterns.AbstractFactory
{
    internal class Tea : IHotDrink
    {
        private int _amount;

        public Tea(int amount)
        {
            _amount = amount;
        }

        public string Consume()
        {
            return $"that is Tea, {nameof(_amount)} = {_amount}";
        }
    }

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            return new Tea(amount);
        }
    }
}
