namespace TicTacToe___Group_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Tic-Tac-Toe game!");
        Support s = new Support();
        bool gameOver = false;
        
        // Used to initialize the game board and show empty spaces
        char[] gameBoard = ['-', '-', '-', '-', '-', '-', '-', '-', '-'];
        
        // Used to indicate what number users should enter to enter to place a mark at their desired spot
        char[] placeBoard = ['1', '2', '3', '4', '5', '6', '7', '8', '9']; 
        
        // User's mark options (Player one is 'X' and Player 2 is 'O"
        char[] markOptions = ['X', 'O'];
        
        // Player 1 starts
        int playerTurn = 1;
        
        while (!gameOver)
        {
            int playerInput = 0;
            bool valid = false;
            s.PrintBoard(placeBoard);
            Console.WriteLine($"Player {playerTurn}, where do you want to place your mark?");
            
            // Only accepts a number that doesn't have a mark and is between 1-9
            while (!valid)
            {
                try
                {
                    playerInput = (Convert.ToInt32(Console.ReadLine()) - 1);
                    if (playerInput >= 0 && playerInput < 9 && gameBoard[playerInput] == '-')
                    {
                        gameBoard[playerInput] = markOptions[playerTurn - 1]; // Decrements to account for 0 index
                        placeBoard[playerInput] = markOptions[playerTurn - 1]; // Decrements to account for 0 index
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid, unused position for your mark."); 
                    }
                }
                catch
                {
                   Console.WriteLine("Invalid input, please try again.");     
                }
                s.PrintBoard(gameBoard);
                Console.WriteLine("----------------------------------------------");
            }
            
            
            bool[] winnerInfo = s.CheckWinner(gameBoard);
            if (winnerInfo[0])
            {
                gameOver = true;
                if (winnerInfo[1])
                {
                    Console.WriteLine("Player 1 won!");
                }
                else
                {
                    Console.WriteLine("Player 2 won!");
                }
            }
            if (playerTurn == 1)
            {
                playerTurn = 2;
            }
            else
            {
                    playerTurn = 1;
            }
                // decide whether or not the game has ended
        }
        
    }
    
}
