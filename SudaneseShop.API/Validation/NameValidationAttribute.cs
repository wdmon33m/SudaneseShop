using System.ComponentModel.DataAnnotations;

public class NameValidationAttribute : ValidationAttribute
{
    public NameValidationAttribute()
    {
        ErrorMessage = "{0} can't be null";
    }

    public override bool IsValid(object? value)
    {
        if (value is null)
        {
            ErrorMessage = "{0} can't be null";
            return false;
        }

        string? name = value.ToString();
        if (name?.Length < 3 || name?.Length > 100)
        {
            ErrorMessage = "{0} must be between 3 and 100 characters long";
            return false;
        }

        return true;
    }
}
