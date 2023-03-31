# TicTacToe Console Application
*Jeyakumar Sathanan,  Hasametaj Zeke, Zenger Nikita*

# Inhalt
- [Aufgabe](#aufgabe)
- [Vorgehen](#vorgehen)
- [Klassendiagram](#klassendiagram)
- [Projektziel](#projektziel)
    - [Links](#links)
- [Planung](#planung)
- [Sprint 1](#sprint-1)
    - [Sprintziel](#sprintziel)
    - [Review](#review)
    - [Retrospektive](#retrospektive)
- [Sprint 2](#sprint-2)
    - [Sprintziel](#sprintziel-1)
    - [Review](#review-1)
    - [Retrospektive](#retrospektive-1)
- [Sprint 3](#sprint-3)
    - [Sprintziel](#sprintziel-2)
    - [Review](#review-2)
    - [Retrospektive](#retrospektive-2)
- [Dokumentation](#dokumentation-code)
    - [Mein Main Code](#mein-main-code)
    - [Testing Code](#testing-code)

# Aufgabe
Die Aufgabe war es ein Tik Tak Toe Spiel in C# umzusetzen wo man den Letzten Spielzug Rückgängig machen kann, das Spiel Beenden kann, ein neues Spiel starten kann und Tik Tak Toe nach den standard Regeln des Klassikers spielen kann.

# Vorgehen
Wir sind wie folgt vorgegange: wir haben uns zuerst überlegt, wie man das Spiel technisch umsetzt, dannach haben wir entschieden wie man die Funktionen des Spiels aufteilt.

# Projektziel
Eine kleine Applikation sollte für die CMD erstellt werden. Es sollte ein TicTacToe-Spiel werden, welches drei Commands annimmt (neu, ende, undo), zudem je nach Feldname soll ein neuer Charakter indessen Feld plaziert werden. 
Das Spiel sollte von zwei Spielern gespielt werden, somit soll ein "X" und "O" Charakter abwechselnd mit der Eingabe plaziert werden. 

Mit der Eingabe "neu", sollte das Feld zurückgesetzt werden.
Mit "undo", soll der letzte Schritt Rückgängig gemacht werden und mit "ende" sollte das Spiel fertig sein, somit die Konsole keine weiteren Werte annehmen.
## Links
[GitHub-Repository](https://github.com/ZekeHasametaj/TicTacToe)<br>
[Azure-DevOps](https://dev.azure.com/NikitaZenger/V320_TicTacToe)


# Planung
## Priorsierungsdiagramm
![Priorisierung-Diagramm](https://user-images.githubusercontent.com/112382296/229237098-b09b8b85-d707-490b-8b53-cb34b5e90fa5.png)



## Use-Case Diagramm
![UseCase-Diagramm](https://user-images.githubusercontent.com/112382296/229237220-7c4f0570-0350-4499-8bae-aa6639fc80f4.png)



## Klassendiagram
![Klassendiagram](https://user-images.githubusercontent.com/112382296/229237257-eed0a06b-9051-4c05-b8b1-5f65b5c5d5b2.png)


# Sprint 1
## Sprintziel
Unser Ziel für diesen Sprint war es vorallem uns auf die nächsten Sprints vorzubereiten. Den Sprint 1 haben wir vorallem mit planen verbracht, sodass wir im zweiten Sprint so viel wie möglich an technischer Arbeit erledigen können und im letzten Sprint kleine Verbesserungen vornehmen. 


## Review
Während dem Sprint sammelten wir uns vorallem Inforamtionen, um am Projekt arbeiten zu können. Wir begannen mit der Planung, wer was macht und begannen ein GitHub-Repository zu erstellen sowie Azure DevOps zu planen. Zudem erstellten wir unsere Projekt-Vision. Zudem begannen wir mit dem Grid des Codes, sodass die Basics der Basics bis zum Sprint 2 bestehen. 


## Retrospektive
Wir haben alles erreicht was wir wollten und konnten gut unsere Aufgaben aufteilen, sodass jeder etwas zu tun hat. 


# Sprint 2
## Sprintziel
Im Sprint 2 haben wir uns vorallem auf den Code fokusiert, um so viel wie möglich zu erledigen. 


## Review
Grundlegende Funktion von Tik Tak Toe konnten wir umsetzen und implementieren. Im Main haben wir ein Grid festgelegt und die Funktion für den Spielstatus programmiert. Funktionen für den Spielerwechsel nach Zug programmiert. Diagramme von letzter Woche nachgeliefert. 


## Retrospektive
Wir konnten alle Aufgaben erledigen, welche wir erledigen wollten. Einer der Aufgaben wurde nicht als "erledigt" verschoben. 


# Sprint 3
## Sprintziel
Für den letzten Sprint vor der Abgabe ging es vorallem um die Dokumentation und versuchen den Code zu verbessern. Bugs an denen man gescheitert ist diese zu beheben noch einmal versuchen zu überprüfen. 


## Review
Im letzten Sprint konnten wir die Dokumentation fertigstellen und versuchten noch einige Bugs im Code zu fixen, welches leider nicht gelungen ist.


## Retrospektive
Der letzte Sprint ist nicht nach Planung gelaufen. Einer unserer Gruppenmitglieder war krank wärend der Woche, welche das Arbeiten etwas beeinträchtigt hat. 

# Dokumentation Code
Das vorliegende Programm implementiert ein Tic-Tac-Toe Spiel, das vom Benutzer auf der Konsole gespielt werden kann. Das Spiel ist in C# geschrieben und besteht aus der Klasse "Program", die den Spielablauf steuert. Das Spiel bietet die Möglichkeit, das Spiel fortzusetzen oder zu beenden, sowie das Spiel rückgängig zu machen oder neu zu starten.
<img width="430" alt="image" src="https://user-images.githubusercontent.com/112382296/229237479-d7285608-415f-4452-aa85-8c194c1e3a77.png">


Das Spielbrett wird durch ein char-Array mit 9 Elementen dargestellt, die die Zahlen 1 bis 9 enthalten. Jeder Spieler hat ein eigenes Symbol, das entweder "X" oder "O" ist. Der erste Spieler, der drei Symbole in einer horizontalen, vertikalen oder diagonalen Linie hat, gewinnt das Spiel.

Das Spiel beginnt mit der Abfrage, ob der Benutzer das Spiel fortsetzen oder beenden möchte. Wenn der Benutzer das Spiel fortsetzen möchte, wird das Spielbrett angezeigt und der erste Spieler wird ausgewählt. Der Benutzer wird aufgefordert, eine Zahl von 1 bis 9 auszuwählen, um seine Platzierung auf dem Spielbrett zu machen. Wenn das ausgewählte Feld bereits mit einem Symbol gefüllt ist, wird der Benutzer aufgefordert, ein anderes Feld auszuwählen. Wenn das ausgewählte Feld noch nicht belegt ist, wird das Symbol des aktuellen Spielers in das Feld eingefügt und der nächste Spieler ist an der Reihe.

Das Spiel bietet auch die Möglichkeit, den vorherigen Zug rückgängig zu machen oder das Spiel neu zu starten. Wenn der Benutzer "undo" eingibt, wird der vorherige Zug des Spielers rückgängig gemacht und das Spielbrett wird aktualisiert. Wenn der Benutzer "neu" eingibt, wird das Spielbrett auf den Anfangszustand zurückgesetzt. Wenn der Benutzer "ende" eingibt, wird das Spiel beendet.

Wenn ein Spieler drei Symbole in einer horizontalen, vertikalen oder diagonalen Linie hat, wird der Spieler zum Gewinner erklärt. Wenn das Spielbrett vollständig gefüllt ist und keiner der Spieler gewonnen hat, wird das Spiel als unentschieden erklärt. Der Benutzer wird aufgefordert, das Spiel neu zu starten oder zu beenden.

Das Spiel bietet auch eine Heads-Up-Anzeige, die den aktuellen Spieler und seine Platzierung auf dem Spielbrett anzeigt. Die Heads-Up-Anzeige wird jedes Mal aktualisiert, wenn ein Spieler einen Zug macht.

Insgesamt ist das Programm gut strukturiert und implementiert alle Funktionen, die für ein einfaches Tic-Tac-Toe-Spiel benötigt werden.

## Mein Main Code
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

## Testing Code
      using Microsoft.VisualStudio.TestTools.UnitTesting;
      using System;
      using Xunit;

      namespace TicTacTo.Tests
      {
          public class ProgramTests
          {
              public object Program { get; private set; }

              [Fact]
              public void CheckWinner_Returns_0_When_Game_Is_Not_Over()
              {
                  // Arrange
                  var gameMarks = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                  // Act
                  var result = Program.CheckWinner(gameMarks);

                  // Assert
                  Assert.Equals(0, result);
              }

              [Fact]
              public void CheckWinner_Returns_1_When_X_Wins_Horizontally()
              {
                  // Arrange
                  var gameMarks = new char[] { 'X', 'X', 'X', '4', '5', '6', '7', '8', '9' };

                  // Act
                  var result = Program.CheckWinner(gameMarks);

                  // Assert
                  Assert.Equal(1, result);
              }

              [Fact]
              public void CheckWinner_Returns_1_When_X_Wins_Vertically()
              {
                  // Arrange
                  var gameMarks = new char[] { 'X', '2', '3', 'X', '5', '6', 'X', '8', '9' };

                  // Act
                  var result = Program.CheckWinner(gameMarks);

                  // Assert
                  Assert.Equals(1, result);
              }

              [Fact]
              public void CheckWinner_Returns_1_When_X_Wins_Diagonally()
              {
                  // Arrange
                  var gameMarks = new char[] { 'X', '2', '3', '4', 'X', '6', '7', '8', 'X' };

                  // Act
                  var result = Program.CheckWinner(gameMarks);

                  // Assert
                  Assert.Equals(1, result);
              }

              [Fact]
              public void CheckWinner_Returns_2_When_Game_Is_A_Draw()
              {
                  // Arrange
                  var gameMarks = new char[] { 'X', 'O', 'X', 'O', 'O', 'X', 'X', 'X', 'O' };

                  // Act
                  var result = Program.CheckWinner(gameMarks);

                  // Assert
                  Assert.Equals(2, result);
              }
          }
      }
      
