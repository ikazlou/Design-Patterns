namespace NestedFactory;

public class Program
{
    public static void Main(string[] args)
    {
        var newPointer = Point.Factory.NewPolarPoint(1, 2); // Через публичное статическое поле для доступа к фабрике
        var newPointer2 = Point.PointFactory.NewCartesianPoint(1, 2);
    }
}