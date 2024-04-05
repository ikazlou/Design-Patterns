namespace ClassicFactory
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var p = PointFactory.NewCartesianPoint(2, 3);
        }
    }
}