using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RegexExercise.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public class RegexValidationAttribute: ValidationAttribute
{
    public string Pattern { get; }


    public RegexValidationAttribute(string pattern): base()
    {
        Pattern = pattern;
    }
    
    public RegexValidationAttribute(string pattern, string errorMessage) : base() 
    {
        Pattern = pattern;
        ErrorMessage = errorMessage;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(value?.ToString()))
        {
            return ValidationResult.Success;
        }
        
        var isMatch = Regex.IsMatch(value.ToString() ?? string.Empty, Pattern);

        if (!isMatch)
        {
            return new ValidationResult(ErrorMessage, [validationContext.MemberName!]);
        }
        
        return ValidationResult.Success;
    }
}