//Valery Lot
//09/15/2026
//Challenge #2 Guess It
//We used the Random class to generate a random number then created a game where we ask the user to guess the number. They are able to choose which level difficulty or even custom range that they input themselves.
//Peer Review Name: Callen Thomason
/*
Flow chart is a little simple. There are process's that should be decisions
Code runs well, and the game plays as intended. 
On custom setting a max lower than the min causes a run time error. Try making a lower max an invalid input.
Your allowed to guess numbers outside the min and max range. Might be helpful to make those invaid inputs also
Code runs, but is a bit over complicated. Only the variables needed to change. 
Good job setting the max's to +1 over what they have to be. 
Great work with all the validation. 
*/

Console.Clear();

GuessingGame gameOne = new GuessingGame();
// Console.WriteLine(gameOne.randNum);

//CHOOSE MODE 1
do
{
    gameOne.StartGame();
    gameOne.SelectMode();



    if (gameOne.chooseMode == 1)
    {
        gameOne.RandomNumber(1, 11);
        while (gameOne.playerGuess != gameOne.randNum)
        {
            gameOne.MakeGuess();
            gameOne.CheckGuess();
        }
    }
    else if (gameOne.chooseMode == 2)
    {
        gameOne.RandomNumber(1, 51);
        while (gameOne.playerGuess != gameOne.randNum)
        {
            gameOne.MakeGuess2();
            gameOne.CheckGuess();
        }
    }
    else if (gameOne.chooseMode == 3)
    {
        gameOne.RandomNumber(1, 101);

        while (gameOne.playerGuess != gameOne.randNum)
        {
            gameOne.MakeGuess3();
            gameOne.CheckGuess();
        }
    }
    else if (gameOne.chooseMode == 4)
    {
        gameOne.MakeGuess4Min();
        gameOne.MakeGuess4Max();
        gameOne.RandomNumber(gameOne.customMin, gameOne.customMax);
        while (gameOne.playerGuess != gameOne.randNum)
        {
            gameOne.MakeGuess4();
            gameOne.CheckGuess();
        }
    }
} while (gameOne.PlayAgain());

