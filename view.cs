public class View 
{
    public void Display(Model model) 
    {
        Console.WriteLine("Displaying the model!");
        Console.WriteLine(model.ToString());
    }

    public void DisplayMessage(string message) 
    {
        Console.WriteLine(message);
    }
}