using FabricMethod.FabricMethod;

namespace FabricMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var newPointer1 = Point.NewCartesianPoint(1,2);
            var newPointer2 = Point.NewPolarPoint(3,4);
        }
    }
}