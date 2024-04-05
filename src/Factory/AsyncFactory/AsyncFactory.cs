namespace AsyncFactory;

public static class AsyncFactory
{
    public static async Task<T> Create<T>() where T : IAsyncInit<T>, new()
    {
        return await new T().InitAsync();
    }
}