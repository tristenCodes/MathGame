using MathGame.Enums;

namespace MathGame.Menu;
using MathGame.Game;

public class Menu(Game game)
{
    
    public void DisplayMainMenu()
    {
        Console.WriteLine("Welcome to Math Game.\nWhat kind of question would you like?");
        Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
    }
    
    public void HandleOptionSelection(string input)
    {
        if (input == "1")
        {
            game.CreateQuestion(Operation.Addition);
            string question = game.Question;
            Console.WriteLine($"question: {question}");
        }
        else if (input == "2")
        {
            game.CreateQuestion(Operation.Subtraction);
            string question = game.Question;
            Console.WriteLine($"question: {question}");
        }
        else if (input == "3")
        {
            game.CreateQuestion(Operation.Multiplication);
            string question = game.Question;
            Console.WriteLine($"question: {question}");
        }
        else if (input == "4")
        {
            game.CreateQuestion(Operation.Division);
            string question = game.Question;
            Console.WriteLine($"question: {question}");
        }
        else
        {
            Console.WriteLine("Invalid Entry");
        }
    }
}