namespace OptionTypeTwoWays.Extensions;

internal static class PrintExtensions
{
    public static PositiveNumberChecker WriteNumber(
        this PositiveNumberChecker positiveNumberChecker)
    {
        Console.WriteLine($"\nNumber: {positiveNumberChecker.Number}");

        return positiveNumberChecker;
    }


    public static PositiveNumberChecker WriteTitle(
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
