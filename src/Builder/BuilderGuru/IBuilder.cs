namespace BuilderGuru;

// Интерфейс Строителя объявляет создающие методы для различных частей
// объектов Продуктов.
public interface IBuilder
{
    void BuildPartA();

    void BuildPartB();

    void BuildPartC();
}