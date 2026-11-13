namespace Common;

public static class ConsoleInput
{
    public static T Read<T>(string prompt = "") where T : IParsable<T>
    {
        while (true)
        {
            Console.Write(prompt);
            if (T.TryParse(Console.ReadLine(), null, out T? value))
                return value;

            Console.WriteLine($"Invalid input, expected a {typeof(T).Name}. Try again.");
        }
    }

    public static T[] ReadMany<T>(string prompt = "") where T : IParsable<T>
    {
        Console.Write(prompt);
        return (Console.ReadLine() ?? "")
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(s => T.Parse(s, null))
            .ToArray();
    }
}