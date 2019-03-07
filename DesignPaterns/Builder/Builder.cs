using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.Builder
{
    class HtmlElement
    {
        public string Name { get => _name; set => _name = value; }
        private string _name;

        public string Text { get => _text; set => _text = value; }
        private string _text;

        public List<HtmlElement> Elements = new List<HtmlElement>();
            
        private const int _indentSize = 2;

        public HtmlElement() { }

        public HtmlElement(string name, string text)
        {
            _name = name;
            _text = text;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', _indentSize * indent);

            sb.Append($"{i} <{_name}>\n");

            if (!string.IsNullOrEmpty(_text))
            {
                sb.Append(new string(' ', _indentSize * (indent + 1)));
                sb.Append(_text);
                sb.Append("\n");
            }

            foreach (var element in Elements)
                sb.Append(element.ToStringImpl(indent + 1));

            sb.Append($"{i}</{_name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }

    class HtmlBuilder
    {
        private readonly string _rootName;
        private HtmlElement _root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            _root.Name = _rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement();
        }

    }

    public class Builder
    {
        public void Run()
        {
            
        }
    }
}
