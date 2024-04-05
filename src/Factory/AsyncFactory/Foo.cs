﻿namespace AsyncFactory;

public class Foo : IAsyncInit<Foo>
{
    public Foo()
    {
        // await Task.Delay(1000); нельзя асинхронно инициализировать конструктор
    }

    public async Task<Foo> InitAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("Task.Delay(1000)");
        return this;
    }

    public static async Task<Foo> CreateAsync()
    {
        var result = new Foo();
        return await result.InitAsync();
    }
}