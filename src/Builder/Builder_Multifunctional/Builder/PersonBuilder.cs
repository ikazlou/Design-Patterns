namespace Builder_Multifunctional.Builder;

public class PersonBuilder // Facade
{
    protected Person Person;

    public PersonBuilder()
    {
        Person = new Person();
    }

    public PersonBuilder(Person person)
    {
        Person = person;
    }

    public PersonAddressBuilder Lives => new(person: Person);

    public PersonJobBuilder Works => new(Person);

    public static implicit operator Person(PersonBuilder personBuilder)
    {
        return personBuilder.Person;
    }
}