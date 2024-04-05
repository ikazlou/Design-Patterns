using System.Reflection;

namespace FabricMethod.FabricMethod;

public class Point
{
    private double x, y;

    private Point(double x, double y) // переписали конструктор на Private и идея в том что пользователь больше не сможем создавать объекты через него
    {
        this.x = x;
        this.y = y;
    }

        // Фабричный метод
    public static Point NewCartesianPoint(double x, double y)
    {
        Console.WriteLine(MethodBase.GetCurrentMethod());
        return new Point(x, y);
    }

    public static Point NewPolarPoint(double rho, double theta)
    {
        // Фабричный метод
        Console.WriteLine(MethodBase.GetCurrentMethod());
        return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
}