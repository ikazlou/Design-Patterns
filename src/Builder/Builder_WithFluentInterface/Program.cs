namespace Builder_WithFluentInterface;

static class Program
{
    static void Main(string[] args)
    {
        var words = new[] { "hello", "world" };

        // что бы не заниматься инициализацией здесь на улице, можно
        // его вынести в сам класс HtmlBuilder и метода Create
        //var builder = new HtmlBuilder("ul");
        var builder1 = HtmlElement.Create("ul");
        builder1.Build();

        // fluent интерфейст дает нам возможность писать
        // builder.AddChild("li", words[0]).AddChild("li", words[1]);
        // вместо builder.AddChild("li", words[0]); builder.AddChild("li", words[1]);
        var builder2 = HtmlElement.Create("ul");
        builder2.AddChild("li", words[0])
            .AddChild("li", words[1]);
        Console.WriteLine(builder2.ToString());

        HtmlElement element = HtmlElement.Create("ul")
                                        .AddChild("li", words[0]);

        Console.WriteLine(element.ToString());
    }
}