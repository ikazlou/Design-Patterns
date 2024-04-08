using AbstractFactory.Factory;

namespace AbstractFactory
{
    // Для создания семейств фабрик
    public static class Program
    {
        public static AbstractShapeFactory GetFactory(bool rounded)
        {
            return rounded
                ? new RoundedShapeFactory()
                : new BasicShapeFactory();
        }

        public static void Main(string[] args)
        {
            var basicFactory = GetFactory(false);
            var basicCircle = basicFactory.Create(Shape.Circle);
            basicCircle.Draw();

            var roundedSquare = GetFactory(true).Create(Shape.Square);
            roundedSquare.Draw();

            Console.WriteLine("Hello, World!");
        }
    }
}