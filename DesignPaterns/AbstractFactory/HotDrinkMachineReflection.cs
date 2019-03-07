using System;
using System.Collections.Generic;
using DesignPaterns.AbstractFactory.Interface;

namespace DesignPaterns.AbstractFactory
{
    class HotDrinkMachineReflection
    {
        private List<Tuple<string, IHotDrinkFactory>> _factories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachineReflection()
        {
            foreach (var t in typeof(HotDrinkMachineReflection).Assembly.GetTypes())
            {
                //test if t implement interface
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    _factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)
                        ));
                }
            }
        }

        public IHotDrink MakeDrink(string drinkType, int amount)
        {
            foreach (var tuple in _factories)
            {
                if(tuple.Item1 == drinkType)
                    return tuple.Item2.Prepare(amount);
            }

            return null;
        }
    }
}
