namespace MathGame;
using MenuClass = MathGame.Menu.Menu;
using GameInstance = MathGame.Game.Game;

class Program
{
    static void Main(string[] args)
    {
        GameInstance game = new GameInstance();
        MenuClass menu = new MenuClass(game);
        
        menu.DisplayMainMenu();
        string questionSelection = Console.ReadLine();
        menu.HandleOptionSelection(questionSelection);
        string userAnswer = Console.ReadLine();
        game.HandleUserAnswer(userAnswer);

    }
}
