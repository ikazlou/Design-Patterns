namespace Builder_Guru;

static class Program
{
    static void Main(string[] args)
    {
        // Клиентский код создаёт объект-строитель, передаёт его директору,
        // а затем инициирует  процесс построения. Конечный результат
        // извлекается из объекта-строителя.
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Standard full featured product:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        // Помните, что паттерн Строитель можно использовать без класса
        // Директор.
        Console.WriteLine("Custom product:");
        builder.BuildPartA();
        builder.BuildPartC();
        Console.Write(builder.GetProduct().ListParts());
    }
}