using FluentValidation.Results;

namespace OA.Console;

public static class ValidatorExecuter
{
    public static void HasError(ValidationResult result)
    {
        if (!result.IsValid)
            result.Errors.ForEach(e => System.Console.WriteLine(e.ErrorMessage));
    }
}
