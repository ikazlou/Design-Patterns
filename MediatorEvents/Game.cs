namespace MediatorEvents;

/// <summary>
///     Класс посредние между игроком и тренером
/// </summary>
public class Game
{
    public event EventHandler<GameEventArgs> GameEvent;

    public void Fire(GameEventArgs args)
    {
        GameEvent?.Invoke(this, args);
    }
}