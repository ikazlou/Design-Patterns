namespace Mediator;

internal class Program
{
    /// <summary>
    ///     Медиатор (или Mediator) — это поведенческий паттерн проектирования,
    ///     который используется для организации взаимодействия между объектами,
    ///     не создавая прямых зависимостей между ними.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var chatRoom = new ChatRoom();
        var firstPerson = new Person("Slava");
        var secondPerson = new Person("Max");

        chatRoom.Join(firstPerson);
        chatRoom.Join(secondPerson);

        firstPerson.Say("Hi");
        secondPerson.Say("Hello");

        var thirdPerson = new Person("Illia");
        chatRoom.Join(thirdPerson);
        thirdPerson.Say("Hi everyone");

        firstPerson.PrivateMessage("Max", "Go play in PS4");
    }
}