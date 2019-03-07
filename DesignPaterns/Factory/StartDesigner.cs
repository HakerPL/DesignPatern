using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.Factory
{
    public class StartDesigner
    {
        public static string Start()
        {
            string returnString = "";

            Point cartesianMethodFactory = Point.PointCartesianFactoryMethod(3, 5);
            Point polarMethodFactory = Point.PointPolarFactoryMethod(3, 5);

            returnString += $"Cartesian method factory {cartesianMethodFactory}\n";
            returnString += $"Polar method factory {polarMethodFactory}\n";

            Point cartesianFactory = Point.Factory.PointCartesianFactoryMethod(6, 8);
            Point polarFactory = Point.Factory.PointPolarFactoryMethod(6, 8);

            returnString += $"Cartesian factory {cartesianFactory}\n";
            returnString += $"Polar factory {polarFactory}";

            return returnString;
        }
    }
}
