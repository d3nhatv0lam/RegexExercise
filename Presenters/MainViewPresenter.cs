using RegexExercise.Attributes;
using RegexExercise.Models;
using RegexExercise.Repositories;
using RegexExercise.Views;

namespace RegexExercise.Presenters;

public class MainViewPresenter : IDisposable
{
    private readonly IMainView _view;
    private readonly IStaffRepository _staffRepository;

    public MainViewPresenter(IMainView view, IStaffRepository staffRepository)
    {
        _view = view;
        _staffRepository = staffRepository;

        _view.UpdateFieldChanged += OnUpdateFieldChanged;
        _view.UpdateEmployeeClicked += OnUpdateEmployeeClicked;
        _view.Loaded += OnViewLoaded;
    }

    private async void OnViewLoaded(object? sender, EventArgs e)
    {
        _view.LoadStaffs(await _staffRepository.GetAll());
    }

    private void OnUpdateFieldChanged(object? sender, FieldChangedEventArgs e)
    {
        var errorMessage = ReflectionValidator.ValidateProperty(new Staff(), e.FieldName, e.Value);
        if (errorMessage is not null)
            _view.SetFieldError(e.FieldName, errorMessage);
    }

    private async void OnUpdateEmployeeClicked(object? sender, Staff staff)
    {
        var errorMessages = ReflectionValidator.ValidateObject(staff);
        if (errorMessages.Count > 0)
        {
            _view.SetFieldError(errorMessages);
            return;
        }

        // update vào db
        var updated = await _staffRepository.Update(staff);
        if (updated)
            _view.LoadStaffs(await _staffRepository.GetAll());
    }

    public void Dispose()
    {
        _view.UpdateFieldChanged -= OnUpdateFieldChanged;
        _view.UpdateEmployeeClicked -= OnUpdateEmployeeClicked;
    }
}