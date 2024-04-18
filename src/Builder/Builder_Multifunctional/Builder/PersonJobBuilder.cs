﻿namespace Builder_Multifunctional.Builder;

public class PersonJobBuilder : PersonBuilder
{
    public PersonJobBuilder(Person person) : base(person)
    {
    }

    public PersonJobBuilder At(string companyName)
    {
        Person.CompanyName = companyName;
        return this;
    }

    public PersonJobBuilder AsA(string position)
    {
        Person.Position = position;
        return this;
    }

    public PersonJobBuilder Earning(int annualIncome)
    {
        Person.AnnualIncome = annualIncome;
        return this;
    }
}