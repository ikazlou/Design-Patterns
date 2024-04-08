namespace AbstractFactory.Factory;

public abstract class AbstractShapeFactory
{
    public abstract IShape Create(Shape shape);
}