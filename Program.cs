namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
      
            char[,] board = new char[3, 3] { { '0', '0', '0' }, { '0', '0', '0' }, { '0', '0', '0' } };
            Console.WriteLine("Tic Tac Toe Board:");
            Console.WriteLine();
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
        }
    }
    
}
