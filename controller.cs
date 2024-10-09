public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void UpdateName()
    {
        _view.DisplayMessage("Enter the new name:");
        string? newName = Console.ReadLine();
        _model.Name = newName;
    }

    public void UpdateAge()
    {
        _view.DisplayMessage("Enter the new age:");
        if (int.TryParse(Console.ReadLine(), out int newAge))
        {
            _model.Age = newAge;
        }
        else
        {
            _view.DisplayMessage("Invalid input. Age must be a number.");
        }
    }

    public void ShowModel()
    {
        _view.Display(_model);
    }
}