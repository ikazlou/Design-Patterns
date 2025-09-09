namespace MediatorEvents;

public class Player
{
    private readonly string _playeNname;
    private readonly Game _game;
    private int _goalScored;

    public Player(string name, Game game)
    {
        _playeNname = name;
        _game = game;

        _game.GameEvent += (sender, args) =>
        {
            if (args is PlayerScoredEventArgs scoredEventArgs) Console.WriteLine($"Player with name {scoredEventArgs.PlayerName} contracted a goal ");
        };
    }

    public void GoalScored()
    {
        _goalScored++;
        var args = new PlayerScoredEventArgs(_goalScored, _playeNname);
        _game.Fire(args);
    }
}