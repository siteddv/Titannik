internal class Program
{
    public static void Main(string[] args)
    {
        const string spliter = "--------------------------------------------------------";
        ShowGreeting();
        int plusId = 10, minusId = 11, multiplyId = 12, divideId = 13;

        int[] operatorsIds = { plusId, minusId, multiplyId, divideId };
        Dictionary<int, int> operatorMaxValues = new Dictionary<int, int>
        {
            { plusId, 100 },
            { minusId, 100 },
            { multiplyId, 10 }
        };

        while (true)
        {
            Random rnd = new Random();
            int randomOperatorId = rnd.Next(operatorsIds.Length);
            int maxNumber = operatorMaxValues[randomOperatorId];
            int? expectedResult = ConductOperation(maxNumber, maxNumber, randomOperatorId);

            if (expectedResult == null)
            {
                continue;
            }

            ReviewAnswer(expectedResult);
            Console.WriteLine(spliter);
        }
    }

    /// <summary>
    /// Recieves answer from user and reviews correctness of it
    /// </summary>
    /// <param name="expectedResult"></param>
    static void ReviewAnswer(int? expectedResult)
    {
        Console.Write("type answer here:");
        string answer = Console.ReadLine();
        if (answer == "stop")
        {
            return;
        }

        int.TryParse(answer, out int actualResult);
        if (actualResult == expectedResult)
        {
            Console.WriteLine("Congratulations it is correct answer!");
        }
        else
        {
            Console.WriteLine($"{actualResult} is wrong answer. Correct is {expectedResult}");
        }
    }

    /// <summary>
    /// Conducts operation on numbers depending on operatorId and returns result
    /// </summary>
    /// <param name="maxNumber1">Max first number </param>
    /// <param name="maxNumber2">Max second number</param>
    /// <param name="operatorId">Operator Id</param>
    /// <returns></returns>
    static int? ConductOperation(int maxNumber1, int maxNumber2, int operatorId)
    {
        int? result = null;
        Random rnd = new Random();

        int number1 = rnd.Next(1, maxNumber1 + 1);
        int number2 = rnd.Next(1, maxNumber2 + 1);

        if (operatorId == 0)
        {
            Console.WriteLine($"Please Solve: {number1} + {number2} = <..>");
            result = number1 + number2;
        }
        else if (operatorId == 1)
        {
            Console.WriteLine($"Please Solve: {number1} - {number2} = <..>");
            result = number1 - number2;
        }
        else if (operatorId == 2)
        {
            Console.WriteLine($"Please Solve: {number1} * {number2} = <..>");
            result = number1 * number2;
        }
        else
        {
            Console.WriteLine("An error was occured. The program had chosen the wrong operator Id. Retrying...");
        }

        return result;
    }

    /// <summary>
    /// Shows greetings to user
    /// </summary>
    static void ShowGreeting()
    {
        const string spliter = "--------------------------------------------------------";

        Console.WriteLine("Hello, colleague!");
        Console.WriteLine(spliter);
    }
}