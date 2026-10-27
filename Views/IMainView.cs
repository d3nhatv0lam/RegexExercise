using RegexExercise.Models;

namespace RegexExercise.Views;

public interface IMainView
{
    event EventHandler? Loaded;
    event EventHandler<FieldChangedEventArgs>? UpdateFieldChanged;
    
    event EventHandler<Staff>? UpdateEmployeeClicked;

    void SetFieldError(string propertyName, string? errorMessage);
    
    // Dict<propertyName, errorMessage>
    void SetFieldError(Dictionary<string, string> validationErrors);

    void UpdateChangeStatus(bool isSuccess, string message);
    
    void LoadStaffs(IReadOnlyList<Staff> staffs);
}