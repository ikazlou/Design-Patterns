namespace Mediator;

public class ChatRoom
{
    private readonly List<Person> _people = new();

    public void Broadcast(string sender, string message)
    {
        foreach (var p in _people)
            if (p.Name != sender)
                p.Receive(sender, message);
    }

    public void Join(Person person)
    {
        _people.Add(person);

        Broadcast("Room", $"{person.Name} joined");

        person.Room = this;
    }

    public void Message(string source, string destination, string message)
    {
        _people.Find(x => x.Name == source)?.Receive(destination, message);
    }
}