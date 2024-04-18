using Builder_Multifunctional.Builder;

namespace Builder_Multifunctional;

internal static class Program
{
    private static void Main(string[] args)
    {
        var pb = new PersonBuilder();
        Person person = pb
            .Lives
                .At("123 London Road")
                .In("London")
                .WithPostCode("SW12BC")
            .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(1200);

        Console.WriteLine(person);
    }
}