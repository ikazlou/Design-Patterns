using System.Reflection;

namespace NestedFactory;

public class Point
{
    private double x, y;

    private Point(double x, double y) // переписали конструктор на Private и идея в том что пользователь больше не сможем создавать объекты через него
    {
        this.x = x;
        this.y = y;
    }

    // Публичное статическое поле для доступа к фабрике
    public static PointFactory Factory = new PointFactory();

    // Вложенный класс - вложенная вабрика
    public class PointFactory
    {
        // Фабричный метод
        public static Point NewCartesianPoint(double x, double y)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod());
            return new Point(x, y);
        }

        // Фабричный метод
        public Point NewPolarPoint(double rho, double theta)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod());
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
}