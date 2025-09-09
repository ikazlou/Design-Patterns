namespace MediatorEvents;

public class Coach
{
    private readonly Game _game;

    public Coach(Game game)
    {
        _game = game;

        _game.GameEvent += (sender, args) =>
        {
            if (args is PlayerScoredEventArgs scoredEventArgs &&
                scoredEventArgs.GoalScoreSoFar < 3)
                Console.WriteLine($"Coach: Say, well done, {scoredEventArgs.PlayerName}");
        };
    }
}