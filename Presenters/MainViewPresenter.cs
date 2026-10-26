using System.ComponentModel.DataAnnotations;
using RegexExercise.Models;
using RegexExercise.Views;

namespace RegexExercise.Presenters;

public class MainViewPresenter: IDisposable
{
    private readonly IMainView _view;
    
    public MainViewPresenter(IMainView view)
    {
        _view = view;
    
        _view.UpdateFieldChanged += OnUpdateFieldChanged;
        _view.UpdateEmployeeClicked += OnUpdateEmployeeClicked;
    }

    private void OnUpdateFieldChanged(object? sender, FieldChangedEventArgs e)
    {
        var property = typeof(Staff).GetProperty(e.FieldName);
        if (property is null) return;
        
        var context = new ValidationContext(new Staff()) { MemberName = e.FieldName };
        var results = new List<ValidationResult>();

        string? errorMessage = null;
        if (!Validator.TryValidateProperty(e.Value?.Trim(), context, results))
        {
            errorMessage = results.FirstOrDefault()?.ErrorMessage;
        }

        _view.SetFieldError(e.FieldName, errorMessage);
    }

    private void OnUpdateEmployeeClicked(object? sender, Staff staff)
    {
        var context = new ValidationContext(staff);
        var results = new List<ValidationResult>();
        
        bool isValid = Validator.TryValidateObject(staff, context, results, validateAllProperties:true);

        if (!isValid)
        {
            var errors = results
                .Where(x => x.MemberNames.Any())
                .GroupBy(x => x.MemberNames.First())
                .ToDictionary(
                    x => x.Key,
                    // chỉ lấy 1 lỗi đại diện
                    x => x.First().ErrorMessage ?? "Dữ liệu không hợp lệ");
            
            _view.SetFieldError(errors);
            return;
        }
        
        // update vào db
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _view.UpdateFieldChanged -= OnUpdateFieldChanged;
        _view.UpdateEmployeeClicked -= OnUpdateEmployeeClicked;
    }
}