using RegexExercise.Models;

namespace RegexExercise.Views;

public partial class MainView : Form, IMainView
{
    public MainView()
    {
        InitializeComponent();
    }

    public event EventHandler<FieldChangedEventArgs>? UpdateFieldChanged;
    public event EventHandler<Staff>? UpdateEmployeeClicked;
    public void SetFieldError(string fieldName, string? errorMessage)
    {
        throw new NotImplementedException();
    }

    public void SetFieldError(Dictionary<string, string> validationErrors)
    {
        throw new NotImplementedException();
    }

    public void UpdateUpdateStatus(string message)
    {
        throw new NotImplementedException();
    }

    public void LoadData(IReadOnlyList<Staff> employees)
    {
        throw new NotImplementedException();
    }
}
