namespace TicTacToe___Group_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Tic-Tac-Toe game!");
        
        bool gameOver = false;
        
        char[] gameBoard = new char[9];
        char[] markOptions = ['X', 'O'];
        int playerTurn = 1;
        
        while (!gameOver)
        {
            // print game board so they know where to go
            int playerInput = 0;
            Console.WriteLine("Where do you want to place your mark?");
            playerInput = (Convert.ToInt32(Console.ReadLine()) - 1); // validate this later
            if (playerInput >= 0 && playerInput < 9 && gameBoard[playerInput] == '\0')
            {
                gameBoard[playerInput] = markOptions[playerTurn - 1];
            }
            else
            {
                Console.WriteLine("There is already something in that spot, try again.");
            }
            
            // print real game board
            
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
