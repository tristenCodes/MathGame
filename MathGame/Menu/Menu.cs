namespace MathGame.Menu;
using MathGame.Game;

public class Menu
{
    private Game _game;
    public Menu(Game game)
    {
        _game = game;
    }
    
    public void DisplayMainMenu()
    {
        Console.WriteLine("Welcome to Math Game.\nWhat kind of question would you like?");
        Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
    }
    
    public void HandleOptionSelection(string input)
    {
        if (input == "1")
        {
            Console.WriteLine("Addition selected");
            string question = _game.GenerateAdditionQuestion();
            Console.WriteLine(question);
            Console.WriteLine(_game.Answer);
        }
        else if (input == "2")
        {
            Console.WriteLine("Subtraction selected");
        }
        else if (input == "3")
        {
            Console.WriteLine("Multiplication selected");
        }
        else if (input == "4")
        {
            Console.WriteLine("Division selected");
        }
        else
        {
            Console.WriteLine("Invalid Entry");
        }
    }
}