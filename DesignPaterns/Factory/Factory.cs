using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.Factory
{
    /// <summary>
    /// FactoryMethod
    /// </summary>
    class Point
    {
        // FactoryMethod
        public static Point PointCartesianFactoryMethod(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point PointPolarFactoryMethod(double rho, double theta)
        {
            double rhoValue = rho * Math.Cos(theta);
            double theraValue = rho * Math.Sin(theta);
            return new Point(rhoValue, theraValue);
        }

        private double _x, _y;

        private Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
        }

        // if we wnat to have private constructor then we must add factory to class
        public static class Factory
        {
            public static Point PointCartesianFactoryMethod(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point PointPolarFactoryMethod(double rho, double theta)
            {
                double rhoValue = rho * Math.Cos(theta);
                double theraValue = rho * Math.Sin(theta);
                return new Point(rhoValue, theraValue);
            }
        }
    }
}
