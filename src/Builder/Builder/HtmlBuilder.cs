namespace Builder;

public class HtmlBuilder
{
    private readonly string _rootName;
    private HtmlElement _root = new();

    public HtmlBuilder(string rootName)
    {
        _rootName = rootName;
        _root.Name = rootName;
    }

    public void AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);
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
}