using RegexExercise.Models;

namespace RegexExercise.Views;

public interface IMainView
{
    event EventHandler<FieldChangedEventArgs>? UpdateFieldChanged;
    
    event EventHandler<Staff>? UpdateEmployeeClicked;

    void SetFieldError(string fieldName, string? errorMessage);
    
    // Dict<field_name, errorMessage>
    void SetFieldError(Dictionary<string, string> validationErrors);
    
    void UpdateUpdateStatus(string message);
    
    void LoadStaffs(IReadOnlyList<Staff> staffs);
}