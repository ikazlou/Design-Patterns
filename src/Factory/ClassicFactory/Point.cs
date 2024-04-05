namespace ClassicFactory
{
    public class Point
    {
        private double x, y;

        public Point(double x, double y) // переписали конструктор на Private и идея в том что пользователь больше не сможем создавать объекты через него
        {
            this.x = x;
            this.y = y;
        }

        // для создания классической фабрики из  фабричного метода достаточно будет вынести фабричные методы в отдельный класс
        //public static Point NewCartesianPoint(double x, double y) => new Point(x, y); // Фабричный метод
        //public static Point NewPolarPoint(double rho, double theta) => new Point(rho * Math.Cos(theta), rho * Math.Sin(theta)); // Фабричный метод

    }
}
