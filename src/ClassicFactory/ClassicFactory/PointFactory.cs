﻿namespace ClassicFactory
{
    public class PointFactory
    {
        public static Point NewCartesianPoint(double x, double y) => new Point(x, y); // Фабричный метод
        public static Point NewPolarPoint(double rho, double theta) => new Point(rho * Math.Cos(theta), rho * Math.Sin(theta)); // Фабричный метод

    }
}
