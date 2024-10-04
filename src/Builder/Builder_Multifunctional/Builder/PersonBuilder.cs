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

    public PersonAddressBuilder Lives => new(Person);

    public PersonJobBuilder Works => new(Person);

    /// <summary>
    ///     implicit определяет неявное преобразование. Это значит, что когда требуется объект класса Person,
    ///     компилятор автоматически преобразует объект PersonBuilder в объект Person,
    ///     не требуя явного вызова преобразования (например, вызова метода или использования оператора преобразования).
    /// </summary>
    /// <param name="personBuilder"></param>
    /// <returns>Person -> PersonBuilder</returns>
    public static implicit operator Person(PersonBuilder personBuilder)
    {
        return personBuilder.Person;
    }
}