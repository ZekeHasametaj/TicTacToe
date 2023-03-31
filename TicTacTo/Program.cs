using System;

namespace TicTacTo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool playAgain = true;
            do
            {

                // Game Status
                int gameStatus = 0;
                int currentPlayer = -1;
                // dynamic Gameboard // Grid
                char[] gameMarks = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                string[] movesHistory = new string[9];
                int moveIndex = -1;

                do
                {
                    Console.Clear();
                    currentPlayer = GetNextPLayer(currentPlayer);
                    HeadsUpDisplay(currentPlayer);
                    DrawGameboard(gameMarks);

                    // Logic of the game
                    bool undo = false;
                    while (!undo)
                    {
                        string userInput = Console.ReadLine();
                        Console.Clear();
                        switch (userInput)
                        {
                            case "neu":
                                gameMarks = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                                movesHistory = new string[9];
                                moveIndex = -1;
                                Console.Clear();
                                HeadsUpDisplay(currentPlayer);
                                DrawGameboard(gameMarks);
                                break;
                            case "ende":
                                return;
                            case "undo":
                                Console.Clear();
                                HeadsUpDisplay(currentPlayer);
                                DrawGameboard(gameMarks);
                                Console.WriteLine("Change the place");
                                if (moveIndex >= 0)
                                {
                                    gameMarks = UndoMove(movesHistory[moveIndex--], gameMarks, ref moveIndex);
                                }
                                break;
                            default:
                                if (!string.IsNullOrEmpty(userInput) &&
                                    (userInput.Equals("1") ||
                                     userInput.Equals("2") ||
                                     userInput.Equals("3") ||
                                     userInput.Equals("4") ||
                                     userInput.Equals("5") ||
                                     userInput.Equals("6") ||
                                     userInput.Equals("7") ||
                                     userInput.Equals("8") ||
                                     userInput.Equals("9")))
                                {
                                    int.TryParse(userInput, out var gamePlacementMarker);

                                    char currentMarker = gameMarks[gamePlacementMarker - 1];

                                    // if field is already been placed
                                    if (currentMarker.Equals('X') || currentMarker.Equals('O'))
                                    {
                                        HeadsUpDisplay(currentPlayer);
                                        DrawGameboard(gameMarks);
                                        Console.WriteLine("PLacement has already a marker please select another placement.");
                                    }
                                    else
                                    {
                                        // place the symbol and change the player
                                        char playerMarker = GetPlayerMarker(currentPlayer);
                                        gameMarks[gamePlacementMarker - 1] = playerMarker;
                                        movesHistory[++moveIndex] = $"{gamePlacementMarker},{playerMarker}";
                                        undo = true;
                                    }
                                }
                                else
                                {
                                    // Error statement if somebody gives a invalid value
                                    Console.Clear();
                                    HeadsUpDisplay(currentPlayer);
                                    DrawGameboard(gameMarks);
                                    Console.WriteLine("Invalid Value, PLEES change the Value");
                                }
                                break;
                        }
                    }

                    gameStatus = CheckWinner(gameMarks);
                } while (gameStatus.Equals(0));

                Console.Clear();
                HeadsUpDisplay(currentPlayer);
                DrawGameboard(gameMarks);

                if (gameStatus.Equals(1))
                {
                    Console.WriteLine($"Player: {currentPlayer} is the Winner");
                    Console.WriteLine("If you want to play again write neu. If you want to end the game write ende!");
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "ende")
                    {
                        playAgain = false;
                    }
                    if (userInput2 == "neu")
                    {
                        gameMarks = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                        movesHistory = new string[9];
                        moveIndex = -1;
                        Console.Clear();
                        HeadsUpDisplay(currentPlayer);
                        DrawGameboard(gameMarks);
                    }
                    if (userInput2 != "ende" && userInput2 != "neu")
                    {
                        Console.WriteLine("Invalid Value, PLEES change the Value");
                    }

                }
                if (gameStatus.Equals(2))
                {
                    Console.WriteLine("The Game is Draw!");
                    Console.WriteLine("If you want to play again write neu. If you want to end the game write ende!");
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "ende")
                    {
                        playAgain = false;
                    }
                    if (userInput2 == "neu")
                    {
                        gameMarks = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                        movesHistory = new string[9];
                        moveIndex = -1;
                        Console.Clear();
                        HeadsUpDisplay(currentPlayer);
                        DrawGameboard(gameMarks);
                    }
                    if (userInput2 != "ende" && userInput2 != "neu")
                    {
                        Console.WriteLine("Invalid Value, PLEES change the Value");
                    }
                }
            } while (playAgain);
            Console.WriteLine("See you later :)");
        }

        private static char[] UndoMove(string move, char[] gameMarks, ref int moveIndex)
{
    if (moveIndex < 0)
    {
        // no previous moves to undo
        return gameMarks;
    }

    var parts = move.Split(',');
    int gamePlacementMarker = int.Parse(parts[0]);
    gameMarks[gamePlacementMarker - 1] = char.Parse(parts[1]) == 'X' ? 'O' : 'X';

    // decrement the move index to undo only the last move
    moveIndex--;

    return gameMarks;
}

        private static int CheckWinner(char[] gameMarks)
        {
            // Game is a Draw
            if (IsGameDraw(gameMarks))
            {
                return 2;
            }

            // A Player Win's
            if (IsGameWinner(gameMarks))
            {
                return 1;
            }

            return 0;
        }

        private static bool IsGameDraw(char[] gameMarks)
        {
            // placed field to have a Draw
            return gameMarks[0] != '1' &&
                   gameMarks[1] != '2' &&
                   gameMarks[2] != '3' &&
                   gameMarks[3] != '4' &&
                   gameMarks[4] != '5' &&
                   gameMarks[5] != '6' &&
                   gameMarks[6] != '7' &&
                   gameMarks[7] != '8' &&
                   gameMarks[8] != '9';
        }

        private static bool IsGameWinner(char[] gameMarks)
        {
            // POssible winning direction
            if (IsGameMMarksTheSame(gameMarks, 0, 1, 2))
            {
                return true;
            }
            if (IsGameMMarksTheSame(gameMarks, 3, 4, 5))
            {
                return true;
            }
            if (IsGameMMarksTheSame(gameMarks, 6, 7, 8))
            {
                return true;
            }
            if (IsGameMMarksTheSame(gameMarks, 0, 3, 6))
            {
                return true;
            }
            if (IsGameMMarksTheSame(gameMarks, 1, 4, 7))
            {
                return true;
            }
            if (IsGameMMarksTheSame(gameMarks, 2, 5, 8))
            {
                return true;
            }
            if (IsGameMMarksTheSame(gameMarks, 0, 4, 8))
            {
                return true;
            }
            if (IsGameMMarksTheSame(gameMarks, 2, 4, 6))
            {
                return true;
            }
            return false;
        }

        private static bool IsGameMMarksTheSame(char[] testGameMarkers, int pos1, int pos2, int pos3)
        {
            // Board position replacing
            return testGameMarkers[pos1].Equals(testGameMarkers[pos2]) && testGameMarkers[pos2].Equals(testGameMarkers[pos3]);
        }

        private static void GameEngine(char[] gameMarks, int currentPlayer)
        {
            // check witch players turn
            bool notValidMove = true;

            do
            {
                // players input
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) &&
                  (userInput.Equals("1") ||
                    userInput.Equals("2") ||
                    userInput.Equals("3") ||
                    userInput.Equals("4") ||
                    userInput.Equals("5") ||
                    userInput.Equals("6") ||
                    userInput.Equals("7") ||
                    userInput.Equals("8") ||
                    userInput.Equals("9")))
                {
                    // because if i don't the the display will double
                    Console.Clear();

                    int.TryParse(userInput, out var gamePlacementMarker);

                    char currentMarker = gameMarks[gamePlacementMarker - 1];

                    // if field is already been placed
                    if (currentMarker.Equals('X') || currentMarker.Equals('O'))
                    {
                        HeadsUpDisplay(currentPlayer);
                        DrawGameboard(gameMarks);
                        Console.WriteLine("PLacement has already a marker please select another placement.");
                    }
                    else
                    {
                        // place the symbol and change the player
                        gameMarks[gamePlacementMarker - 1] = GetPlayerMarker(currentPlayer);
                        notValidMove = false;
                    }
                }
                else
                {
                    // Error statement if somebody gives a invalid value
                    Console.WriteLine("Invalid Value, PLEES change the Value");
                }
            } while (notValidMove);
        }

        private static char GetPlayerMarker(int player)
        {
            // Checking witch player is next
            if (player % 2 == 0)
            {
                return 'O';
            }

            return 'X';
        }

        static void HeadsUpDisplay(int PlayerNumber)
        {
            // Introduction
            Console.WriteLine("Welcome to the Tic Tac Toe Game!");

            // Player announcement
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine();

            // Explaining the structure of the Board
            Console.WriteLine($"Player {PlayerNumber} to move, select 1 thorugh 9 from the game board");
            Console.WriteLine();
        }

        static void DrawGameboard(char[] gameMarks)
        {
            // Board design
            Console.WriteLine($" {gameMarks[0]} | {gameMarks[1]} | {gameMarks[2]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {gameMarks[3]} | {gameMarks[4]} | {gameMarks[5]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {gameMarks[6]} | {gameMarks[7]} | {gameMarks[8]} ");
        }

        // Changing Player
        static int GetNextPLayer(int player)
        {
            if (player.Equals(1))
            {
                return 2;
            }

            return 1;
        }
    }
}

