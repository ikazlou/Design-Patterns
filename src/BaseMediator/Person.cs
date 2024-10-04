namespace Mediator;

public class Person
{
    public string Name;
    public ChatRoom Room;
    private readonly List<string> chatLog = new();

    public Person(string name)
    {
        Name = name;
    }

    public void Receive(string sender, string message)
    {
        var s = $"{sender}: {message}";
        Console.WriteLine($"[{Name}'s chat session] {s}");
        chatLog.Add(s);
    }

    public void Say(string message)
    {
        Room.Broadcast(Name, message);
    }

    public void PrivateMessage(string who, string message)
    {
        Room.Message(Name, who, message);
    }
}