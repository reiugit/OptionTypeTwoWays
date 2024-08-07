using OptionTypeTwoWays;
using OptionTypeTwoWays.Extensions;
using OptionTypeTwoWays.Keyhandler;

Console.WriteLine("\n'OneOf' used as 'Option Type' compared with pure 'Option Type':\n");

var positiveNumberChecker = PositiveNumberChecker.Create(-1);

// 1.) with OneOf<T, None>
positiveNumberChecker
    .WriteTitleAndNumber("OneOf<int, None>")
    .GetPositiveNumberOrNoneWithOneOf() // returns 'OneOf<int, None>'
    .Match(
        _ => "is a positive number",
        _ => "is a negative number")
    .Print();

// 2.) with Option<T>
positiveNumberChecker
    .WriteTitleAndNumber("Option<int>")
    .GetPositiveNumberOrNoneWithLanguageExt() // returns 'Option<int>'
    .Match(
        _ => "is a positive number",
        "is a negative number")
    .Print();

KeyHandler.WaitForKey();
