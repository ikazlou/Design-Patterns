namespace AbstractFactory.Factory;

public class BasicShapeFactory : AbstractShapeFactory
{
    public override IShape Create(Shape shape)
    {
        switch (shape)
        {
            case Shape.Circle:
                return new Circle();
            case Shape.Square:
                return new Square();
            default:
                throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
        }
    }
}