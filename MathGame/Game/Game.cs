namespace MathGame.Game;

public class Game
{
    public static List<string> Games = new List<string>();
    public string Question { get; set; }
    public int Answer { get; set; }
    private readonly Random _rand = new Random();

    public string GenerateAdditionQuestion()
    {
        var randomNumberOne = GenerateRandomNumber(1000);
        var randomNumberTwo = GenerateRandomNumber(1000);
        Answer = randomNumberOne + randomNumberTwo;
        Question = $"{randomNumberOne} + {randomNumberTwo}";
        return Question;
    }

    private int GenerateRandomNumber(int maxValue)
    {
        int randomNumber = _rand.Next(maxValue);
        return randomNumber;
    }
}