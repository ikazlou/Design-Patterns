﻿namespace Builder
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var words = new[] { "hello", "world" };
            var builder = new HtmlBuilder("ul");
            var qwe = builder.Build();

            foreach (var word in words) builder.AddChild("li", word);

            Console.WriteLine(builder.ToString());
        }
    }
}