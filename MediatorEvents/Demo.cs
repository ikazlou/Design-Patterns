namespace MediatorEvents;

public class Program
{
    public static void Main(string[] args)
    {
        var game = new Game();
        var player = new Player("Alex", game);
        var coach = new Coach(game);

        player.GoalScored();
        player.GoalScored();
        player.GoalScored();
        player.GoalScored();
    }
}