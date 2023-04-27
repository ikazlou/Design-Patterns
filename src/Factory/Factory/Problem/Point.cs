namespace Factory.Problem
{
    public class Point
    {
        public double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Так не получится такт как для перегрузки нужны будут отличные от предыдущих типы аргументов
        //public Point(double rho, double theta)
        //{
        //}

        // Для этого нам будет необходимо сливать такие два конструктора в один и давать
        // ему другие спецификации которые позволят понимать какие координаты мы передаем

        public enum CoordinateSystem
        {
            Cartesian,
            Polar
        }

        // Этот конструктор и показывает проблему которую решает проблему
        public Point(double a, double b, CoordinateSystem cs = CoordinateSystem.Cartesian)
        {
            switch (cs)
            {
                case CoordinateSystem.Cartesian:
                    x = a;
                    y = b;
                    break;
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cs), cs, null);
            }
            this.x = x;
            this.y = y;
        }
    }
}
