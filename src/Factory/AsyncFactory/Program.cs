namespace AsyncFactory
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Первый вариант
            // var foo = new Foo();
            // await foo.InitAsync();

            // Второй вариант
            var foo = await Foo.CreateAsync();

            // Третий вариант
            var newFoo = AsyncFactory.Create<Foo>();
            Console.ReadLine();
        }
    }
}