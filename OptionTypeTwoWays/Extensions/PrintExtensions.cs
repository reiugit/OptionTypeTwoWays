namespace OptionTypeTwoWays.Extensions;

internal static class PrintExtensions
{
    public static PositiveNumberChecker WriteTitleAndNumber(
        this PositiveNumberChecker positiveNumberChecker,
        string title)
    {
        Console.Write($"\nWith '{title}':\n{positiveNumberChecker.Number} ");

        return positiveNumberChecker;
    }

    public static void Print<T>(this T value)
    {
        Console.WriteLine(value);
    }
}
