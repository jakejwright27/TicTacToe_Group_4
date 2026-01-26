namespace TicTacToe___Group_4;

public class Support
{
    // Takes input from gamebaord and prints it out  
    public void PrintBoard(char[] gameBoardCopy)
    {
        Console.WriteLine($" {gameBoardCopy[0]} | {gameBoardCopy[1]} | {gameBoardCopy[2]}");
        Console.WriteLine("───┼───┼───"); 
        Console.WriteLine($" {gameBoardCopy[3]} | {gameBoardCopy[4]} | {gameBoardCopy[5]}");
        Console.WriteLine("───┼───┼───"); 
        Console.WriteLine($" {gameBoardCopy[6]} | {gameBoardCopy[7]} | {gameBoardCopy[8]}");
       
    }
    // checks to see if winner
    public bool[] CheckWinner(char[] gameBoard)
    {   
        //set array of bools to determine win condition. Position 0 is if someone won, position 2 is if player 1(x) won. 
        // [0] = someone won, [1] = player 1 (x) won
        bool[] winCondition = new bool[2];
        // Set which lines are winning lines
        int[][] winLines =
        {
            new[] {0,1,2}, new[] {3,4,5}, new[] {6,7,8}, new[] {0,3,6}, new[] {1,4,7},
            new[] {2,5,8}, new[] {0,4,8}, new[] {2,4,6}
        };
        // check all lines to see if its someone won
        foreach (var line in winLines)
        {
            char firstChar = gameBoard[line[0]];
            if (firstChar != ' ' && firstChar == gameBoard[line[1]] && firstChar == gameBoard[line[2]])
            {
                if (firstChar == 'X') // if player 1 wins(x), then update postion 1 
                {
                    winCondition[1] = true;
                    winCondition[0] = true;
                }
                else
                {   
                    // player 2 wins, update to say position 1, player 1 did NOT win 
                    winCondition[1] = false;
                    winCondition[0] = true;
                }
                return winCondition;
            }
  
        } // if no one won, return all as false
        winCondition[0] = false;
        return winCondition;
    }
    
}