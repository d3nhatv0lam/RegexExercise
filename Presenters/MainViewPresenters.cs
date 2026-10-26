using RegexExercise.Views;

namespace RegexExercise.Presenters;

public class MainViewPresenters
{
    private readonly IMainView _view;


    public MainViewPresenters(IMainView view)
    {
        _view = view;
    }
}