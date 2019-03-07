using System;
using System.Collections.Generic;

namespace DesignPaterns._SOLID.Open_Close
{
    /*
     * Open Close
     * cClass should be open for extension but closed for modification
     */

    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == _size;
        }
    }

    public class AddSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first, _secound;

        public AddSpecification(ISpecification<T> first, ISpecification<T> secound)
        {
            _first = first;
            _secound = secound;
        }

        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _secound.IsSatisfied(t);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                    yield return i;
            }
        }
    }

    public class UseGood
    {
        public UseGood()
        {
            var apple = new Product("Apple", Color.Red, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var bf = new BetterFilter();

            Console.WriteLine("Green products (new): ");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {p.Name} is Green");

            Console.WriteLine("Large blue products (new): ");
            foreach (var p in bf.Filter(products, 
                            new AddSpecification<Product>(
                                new ColorSpecification(Color.Blue), 
                                new SizeSpecification(Size.Large))))
                Console.WriteLine($" - {p.Name} is large and blue");
        }
    }
}
