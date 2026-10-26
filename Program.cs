using RegexExercise.Data;
using RegexExercise.Presenters;
using RegexExercise.Repositories;
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

        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
        }
        
        var mainView = new MainView();
        var staffRepository = new StaffRepository();
        var presenter = new MainViewPresenter(mainView, staffRepository);
        
        Application.Run(mainView);
        
        presenter.Dispose();
    }    
}