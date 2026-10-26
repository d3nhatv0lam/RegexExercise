using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace RegexExercise.Attributes;

public static class ReflectionValidator
{
    public static string? ValidateProperty(object instance, string propertyName, object? value)
    {
        var property = instance.GetType().GetProperty(propertyName);
        if (property is null) return null;
        
        var context = new ValidationContext(instance) {MemberName = propertyName};

        var attributes = property.GetCustomAttributes<ValidationAttribute>(inherit: true)
            .OrderByDescending(attr => attr is RequiredAttribute);

        foreach (var attribute in attributes)
        {
            var result = attribute.GetValidationResult(value, context);
            if (result != ValidationResult.Success)
                return result?.ErrorMessage;
        }

        return null;
    }
    
    public static Dictionary<string, string> ValidateObject(object instance)
    {
        var errors = new Dictionary<string, string>();
        
        var properties = instance.GetType().GetProperties();

        foreach (var property in properties)
        {
            var value = property.GetValue(instance);

            var errorMessage = ValidateProperty(instance, property.Name, value);
            if (errorMessage is not null)
                errors.TryAdd(property.Name, errorMessage);
        }

        return errors;
    }
    
    
    // hàm dùng của C#

    public static string? ValidateProperty_UseValidator(object instance, string propertyName, object? value)
    {
        var property = instance.GetType().GetProperty(propertyName);
        if (property is null) return null;
        
        var context = new ValidationContext(instance) {MemberName = propertyName};

        var results = new List<ValidationResult>();

        if (!Validator.TryValidateProperty(value, context, results))
            return results.FirstOrDefault()?.ErrorMessage;

        return null;
    }
    
    public static Dictionary<string, IReadOnlyList<string>> ValidateObject_UseValidator(object instance)
    {
        var context = new ValidationContext(instance);
        var results = new List<ValidationResult>();

        if (!Validator.TryValidateObject(instance, context, results, validateAllProperties:true))
        {
            return results.Where(x => x.MemberNames.Any())
                .GroupBy(x => x.MemberNames.First())
                .ToDictionary(
                    x => x.Key, 
                    x => (IReadOnlyList<string>)x.Select(validationResult => validationResult.ErrorMessage).ToList());
        }

        return new Dictionary<string, IReadOnlyList<string>>();
    }
    
}