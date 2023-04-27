namespace Factory.FabricMethod
{
    public class Point
    {
        private double x, y;

        private Point(double x, double y) // переписали конструктор на Private и идея в том что пользователь больше не сможем создавать объекты через него
        {
            this.x = x;
            this.y = y;
        }

        public static Point NewCartesianPoint(double x, double y) => new Point(x, y); // Фабричный метод
        public static Point NewPolarPoint(double rho, double theta) => new Point(rho * Math.Cos(theta), rho * Math.Sin(theta)); // Фабричный метод

    }
}
