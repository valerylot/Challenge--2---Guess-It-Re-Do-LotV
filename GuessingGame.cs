public class GuessingGame
{
    public int randNum;
    public int chooseMode;
    public int playerGuess;
    public int attempts = 1;
    public int customMin = 0;
    public int customMax = 0;
    public string playAgain;

    public void StartGame()
    {

        Console.WriteLine("Welcome to Guess It. Can you guess my number?");
        Console.WriteLine("Select a mode: 1 = Easy, 2 = Medium, 3 = Hard, 4 = Custom");
    }

    public bool SelectMode()
    {

        Console.Write("Please enter a number 1 - 4: ");
        bool success = int.TryParse(Console.ReadLine(), out chooseMode);

        while (success == false || chooseMode >= 5 || chooseMode == 0)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please enter a number 1 - 4: ");
            success = int.TryParse(Console.ReadLine(), out chooseMode);
        }


        return success;

    }

    public int RandomNumber(int min, int max)
    {
        //creating an instance of the class Random
        Random rnd = new Random();
        randNum = rnd.Next(min, max);
        // Console.WriteLine(randNum);
        return randNum;
    }
    public bool MakeGuess()
    {

        Console.WriteLine("Please enter a number 1-10");
        bool success2 = int.TryParse(Console.ReadLine(), out playerGuess);

        while (success2 == false || playerGuess > 10 || playerGuess == 0)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please enter a number 1 - 10: ");
            success2 = int.TryParse(Console.ReadLine(), out playerGuess);
        }
        return success2;
    }

    public bool MakeGuess2()
    {
        Console.WriteLine("Please enter a number 1-50");
        bool success3 = int.TryParse(Console.ReadLine(), out playerGuess);

        while (success3 == false || playerGuess > 50 || playerGuess == 0)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please enter a number 1 - 50: ");
            success3 = int.TryParse(Console.ReadLine(), out playerGuess);
        }
        return success3;
    }

    public bool MakeGuess3()
    {
        Console.WriteLine("Please enter a number 1-100");
        bool success4 = int.TryParse(Console.ReadLine(), out playerGuess);

        while (success4 == false || playerGuess > 100 || playerGuess == 0)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please enter a number 1-100: ");
            success4 = int.TryParse(Console.ReadLine(), out playerGuess);
        }
        return success4;
    }
    public bool MakeGuess4Min()
    {
        Console.Write("Please enter your minimum number: ");
        bool success5 = int.TryParse(Console.ReadLine(), out customMin);

        while (success5 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please enter a number: ");
            success5 = int.TryParse(Console.ReadLine(), out playerGuess);
        }
        return success5;

    }

    public bool MakeGuess4Max()
    {
        Console.Write("Please enter your maximum number: ");
        bool success6 = int.TryParse(Console.ReadLine(), out customMax);
        while (success6 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write("Please enter a number: ");
            success6 = int.TryParse(Console.ReadLine(), out playerGuess);
        }
        return success6;
    }

    public bool MakeGuess4()
    {
        Console.WriteLine($"Please enter a number between {customMin} and {customMax}");
        bool success7 = int.TryParse(Console.ReadLine(), out playerGuess);

        // Console.WriteLine(randNum); 
        while (success7 == false)
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.Write($"Please guess a number between {customMin} and {customMax}: ");
            success7 = int.TryParse(Console.ReadLine(), out playerGuess);
        }
        return success7;
    }

    public void CheckGuess()
    {
        if (randNum > playerGuess)
        {
            Console.WriteLine("Your guess is LOWER than my number. Try again.");    
        }
        else if (randNum < playerGuess)
        {
            Console.WriteLine("Your guess is HIGHER than my number. Try again.");
        }
        else
        {
            Console.WriteLine("Congrats! You guessed it right.");
            Console.WriteLine($"It took you {attempts} tries.");
        }
        attempts++;
    }

    public bool PlayAgain()
    {
        Console.WriteLine("Do you want to play again? Y / N ");
        playAgain = Console.ReadLine().ToUpper();

        while (playAgain != "Y" && playAgain != "N")
        {
            Console.WriteLine("Invalid input. Please enter Y / N ");
            playAgain = Console.ReadLine().ToUpper();
        }
        if (playAgain == "N")
        {
            Console.WriteLine("Thank you for playing!");
            return false;
        }
        else
        {
            return true;
        }
    }
}