using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.AbstractFactory.Interface
{
    interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
