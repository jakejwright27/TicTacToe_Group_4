namespace TicTacToe___Group_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Tic-Tac-Toe game!");
        Support s = new Support();
        bool gameOver = false;
        
        char[] gameBoard = ['-', '-', '-', '-', '-', '-', '-', '-', '-'];
        char[] placeBoard = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
        char[] markOptions = ['X', 'O'];
        int playerTurn = 1;
        
        while (!gameOver)
        {
            
            int playerInput = 0;
            bool valid = false;
            s.PrintBoard(placeBoard);
            Console.WriteLine($"Player {playerTurn}, where do you want to place your mark?");
            while (!valid)
            {
                try
                {
                    playerInput = (Convert.ToInt32(Console.ReadLine()) - 1);
                    if (playerInput >= 0 && playerInput < 9 && gameBoard[playerInput] == '-')
                    {
                        gameBoard[playerInput] = markOptions[playerTurn - 1];
                        placeBoard[playerInput] = markOptions[playerTurn - 1];
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("There is already something in that spot, try again."); 
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
            if (winnerInfo[0] == true)
            {
                gameOver = true;
                if (winnerInfo[1] == true)
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
