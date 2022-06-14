using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    // Конкретные продукты создаются соответствующими Конкретными Фабриками.
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
