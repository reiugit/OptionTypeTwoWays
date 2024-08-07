using LanguageExt;
using OneOf;
using OneOf.Types;

namespace OptionTypeTwoWays;

internal class PositiveNumberChecker
{
    private readonly int _number;

    private PositiveNumberChecker(int number)
    {
        _number = number;
    }

    public int Number => _number;

    public static PositiveNumberChecker Create(int number)
    {
        return new(number);
    }

    public OneOf<int, None> GetPositiveNumberOrNoneWithOneOf()
    {
        return _number > 0
            ? _number
            : new None();
    }

    public Option<int> GetPositiveNumberOrNoneWithLanguageExt()
    {
        return _number > 0
            ? _number
            : Option<int>.None;
    }
}
