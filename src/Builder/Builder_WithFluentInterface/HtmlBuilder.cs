namespace Builder_WithFluentInterface;

public class HtmlBuilder
{
    private readonly string _rootName;
    private HtmlElement _root = new HtmlElement();

    public HtmlBuilder(string rootName)
    {
        _rootName = rootName;
        _root.Name = rootName;
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);

        // возращаем ссылку на самого себя же
        return this;
    }

    public override string ToString()
    {
        return _root.ToString();
    }

    public void Clear()
    {
        _root = new HtmlElement { Name = _rootName };
    }

    public HtmlElement Build()
    {
        return _root;
    }

    // Таким кодом мы сможем закастовать HtmlBuilder к HtmlElement
    public static implicit operator HtmlElement(HtmlBuilder htmlBuilder)
    {
        return htmlBuilder._root;
    }
}