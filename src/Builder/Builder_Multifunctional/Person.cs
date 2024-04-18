namespace Builder_Multifunctional;

public class Person
{
    // addres information - 1 builder
    public string StreetAddress, PostCode, City;

    // employment info - 2 builder
    public string CompanyName, Position;
    public int AnnualIncome;

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City} \n" +
               $"{nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position} \n" +
               $"{nameof(AnnualIncome)}: {AnnualIncome}";
    }
}