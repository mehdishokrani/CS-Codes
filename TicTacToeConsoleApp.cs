using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp
{
    internal class Program
    {

        public bool correctChoose;
        public int playerTurn = 1;
        public string playerChoose = string.Empty;
        public static string[,] board = new string[3, 3];
        public static string[] input = new string[9];
        static void Main(string[] args)
        {
            do
            {
                for (int i = 1; i < 10; i++)
                {
                    input[i-1] = i.ToString();
                }
                int count = 1;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = count.ToString();
                        count++;
                    }
                }
                count = 0;
                Console.Clear();
                SetField("10", " ");
                bool correctChoose;
                int playerTurn = 1;
                string playerChoose = string.Empty;
                while (count < 9)
                {
                    Console.Write($"Player {playerTurn}: Choose your field: ");
                    playerChoose = Console.ReadLine();
                    correctChoose = checkPlayerChoose(playerChoose);
                    if (correctChoose)
                    {
                        if (playerTurn == 1)
                        {
                            Console.Clear();
                            input[int.Parse(playerChoose) - 1] = "X";
                            SetField(playerChoose, "X");
                            count++;
                            if (checkWinner())
                            {
                                Console.WriteLine("Player 1 WINNER!!!");
                                break;
                            }
                            playerTurn = 2;

                        }

                        else
                        {
                            Console.Clear();
                            input[int.Parse(playerChoose) - 1] = "O";
                            SetField(playerChoose, "O");
                            count++;
                            if (checkWinner())
                            {
                                Console.WriteLine("Player 2 WINNER!!!");
                                break;
                            }
                            playerTurn = 1;

                        }

                    }
                    Console.Clear();
                    SetField("10"," ");
                }
                if (count>9)
                Console.WriteLine("NO one win the game. Press key to restart");
                Console.ReadKey();
            }while(true);
        }

        static bool checkWinner()
        {
            int x = 0, o = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "X")
                    {
                        x++;
                    }
                    else if (board[i, j] == "O")
                    {
                        o++;
                    }
                }
                if (x == 3 || o == 3)
                    return true;
                x = 0;o = 0;

            }
            for (int i = 0,j=2; i < 3; i++,j--)
            {
                if (board[i, j] == "X")
                {
                    x++;
                }
                else if (board[i, j] == "O")
                {
                    o++;
                }
            }
            if (x == 3 || o == 3)
                return true;
            x = 0; o = 0;
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (board[i, j] == "X")
                {
                    x++;
                }
                else if (board[i, j] == "O")
                {
                    o++;
                }
            }
            if (x == 3 || o == 3)
                return true;
            x = 0; o = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == "X")
                    {
                        x++;
                    }
                    else if (board[i, j] == "O")
                    {
                        o++;
                    }
                }
                if (x == 3 || o == 3)
                    return true;
            }
            return false;

        }
        public static bool checkPlayerChoose(string playerChoose)
        {
            if (int.TryParse(playerChoose, out _))
                if (int.Parse(playerChoose) < 10 && int.Parse(playerChoose) > 0)
                    if (input[int.Parse(playerChoose)-1] != "X" && input[int.Parse(playerChoose)-1] != "O")
                    {
                        
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number between 1 to 9");
                        Console.ReadKey();
                        return false;
                    }
            return false;
        }

        public static void SetField( string c,string d)
        {
            int row=4, col=4;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == c)
                    {
                        row = i; col = j; break;
                    }                        
                }
            }
            if (row != 4  && c!="10")
            {
                board[row, col] = d;
            }
            
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", board[0, 0], board[0,1], board[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1,0], board[1,1], board[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2,0], board[2,1], board[2,2]);
            Console.WriteLine("     |     |     ");

        }

    }
}
