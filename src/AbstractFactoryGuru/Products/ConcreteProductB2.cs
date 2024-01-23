using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    // Конкретные продукты создаются соответствующими Конкретными Фабриками.
    public class ConcreteProductB2 : IAbstractProductB
    {
        // Продукт B1 может корректно работать только с Продуктом A1. Тем не
        // менее, он принимает любой экземпляр Абстрактного Продукта А в
        // качестве аргумента.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }
    }
}
