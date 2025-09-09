namespace MediatorEvents;

public class PlayerScoredEventArgs : GameEventArgs
{
    public readonly string PlayerName;
    public readonly int GoalScoreSoFar;

    public PlayerScoredEventArgs(int goalScoreSoFar, string playerName)
    {
        GoalScoreSoFar = goalScoreSoFar;
        PlayerName = playerName;
    }

    public override void Print()
    {
        Console.WriteLine($"{PlayerName} has scored!"
                          + $" Score so far: {GoalScoreSoFar}");
    }
}