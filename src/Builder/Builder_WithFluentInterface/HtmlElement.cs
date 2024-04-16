using System.Text;

namespace Builder_WithFluentInterface
{
    public class HtmlElement
    {
        public string Name;
        private readonly string _text;
        public readonly List<HtmlElement> Elements = new();
        private const int IndentSize = 2;

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            _text = text;
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indent * IndentSize);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(_text))
            {
                sb.Append(new string(' ', IndentSize * (indent + 1)));
                sb.Append(_text);
                sb.Append("\n");
            }

            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        // Фабричный метод
        public static HtmlBuilder Create(string name)
        {
            return new HtmlBuilder(name);
        }
    }
}