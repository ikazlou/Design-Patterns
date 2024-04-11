namespace Factory_Homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var factory = new PersonFactory();
            var person = factory.CreatePerson("Alex");
            var person2 = factory.CreatePerson("Illia");

            Console.WriteLine("Hello, World!");
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    interface IPersonFactory
    {
        Person CreatePerson(string name);
    }

    public class PersonFactory : IPersonFactory
    {
        private int _id;

        public Person CreatePerson(string name)
        {
            var person = new Person(_id, name);
            _id++;

            return person;
        }
    }

}