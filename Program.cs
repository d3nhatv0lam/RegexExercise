using RegexExercise.Presenters;
using RegexExercise.Views;

namespace RegexExercise;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        var mainView = new MainView();
        var presenter = new MainViewPresenter(mainView);
        
        Application.Run(mainView);
        
        presenter.Dispose();
    }    
}