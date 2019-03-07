using System;
using System.Collections.Generic;

namespace DesignPaterns._SOLID.Open_Close
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Product
    {
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private string _name;

        public Color Color
        {
            get => _color;
            set => _color = value;
        }
        private Color _color;

        public Size Size
        {
            get => _size;
            set => _size = value;
        }
        private Size _size;

        public Product(string name, Color color, Size size)
        {
            _name = name;
            _color = color;
            _size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (Product product in products)
            {
                if (product.Size == size)
                    yield return product;
            }
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (Product product in products)
            {
                if (product.Color == color)
                    yield return product;
            }
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (Product product in products)
            {
                if (product.Size == size && product.Color == color)
                    yield return product;
            }
        }
    }


    public class UseWrong
    {
        public UseWrong()
        {
            var apple = new Product("Apple", Color.Red, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = {apple, tree, house};

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old): ");

            foreach (var p in pf.FilterByColor(products, Color.Green))
                Console.WriteLine($" - {p.Name} is Green");
        }
    }
}
