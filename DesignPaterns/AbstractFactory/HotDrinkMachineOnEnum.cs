using System;
using System.Collections.Generic;
using DesignPaterns.AbstractFactory.Interface;

namespace DesignPaterns.AbstractFactory
{
    class HotDrinkMachineOnEnum
    {
        public enum AvailableDrinkType
        {
            Coffee, Tea
        }

        private Dictionary<AvailableDrinkType, IHotDrinkFactory> _factories = 
            new Dictionary<AvailableDrinkType, IHotDrinkFactory>();

        public HotDrinkMachineOnEnum()
        {
            foreach (AvailableDrinkType drinkType in Enum.GetValues(typeof(AvailableDrinkType)))
            {
                var factory = (IHotDrinkFactory) Activator.CreateInstance(
                    Type.GetType("DesignPaterns.AbstractFactory." +
                                 Enum.GetName(typeof(AvailableDrinkType), drinkType) + "Factory"));

                _factories.Add(drinkType, factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrinkType drinkType, int amount)
        {
            return _factories[drinkType].Prepare(amount);
        }
    }
}
