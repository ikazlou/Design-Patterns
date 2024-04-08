namespace AbstractFactory.Factory;

public class RoundedShapeFactory : AbstractShapeFactory
{
    public override IShape Create(Shape shape)
    {
        switch (shape)
        {
            case Shape.Circle:
                return new RoundedCircle();
            case Shape.Square:
                return new RoundedSquare();
            default:
                throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
        }
    }
}