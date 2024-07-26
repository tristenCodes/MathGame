using MathGame.Enums;

namespace MathGame.Game;

public class Game
{
    public static List<string> History = new List<string>();
    public string Question { get; set; }
    private int Answer { get; set; }
    private readonly Random _rand = new Random();
    
    public void CreateQuestion(Operation operation)
    {
        
        
        switch (operation)
        {
            case (Operation.Addition):
                GenerateAdditionQuestionAnswer();
                break;
            case (Operation.Subtraction):
                Question = $"{randomNumbers[0]} - {randomNumbers[1]}";
                Answer = randomNumbers[0] - randomNumbers[1];
                break;
            case (Operation.Multiplication):
                Question = $"{randomNumbers[0]} * {randomNumbers[1]}";
                Answer = randomNumbers[0] * randomNumbers[1];
                break;
            case (Operation.Division):
                Question = $"{randomNumbers[0]} / {randomNumbers[1]}";
                Answer = randomNumbers[0] / randomNumbers[1];
                break;
        }
    }

    public void HandleUserAnswer(string userAnswer)
    {
        try
        {
            int parsedAnswer = int.Parse(userAnswer);
            if (IsCorrectAnswer(parsedAnswer))
            {
                Console.WriteLine("You did it!");
                History.Add("Win");
            }
            else
            {
                Console.WriteLine("You failed big time!");
                History.Add("Loss");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Entry", e);
            throw;
        }
    }
    
    private bool IsCorrectAnswer(int num)
    {
        return num == Answer;
    }
    
    private int GenerateRandomNumber(int maxValue)
    {
        var randomNumber = _rand.Next(maxValue);
        return randomNumber;
    }

    private void GenerateAdditionQuestionAnswer(int maxValue = 100)
    {
        int numberOne = GenerateRandomNumber(maxValue);
        int numberTwo = GenerateRandomNumber(maxValue);
        Question = $"{numberOne} + {numberTwo}";
        Answer = numberOne + numberTwo;
    }
}