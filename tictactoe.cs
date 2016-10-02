using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TicTacToeArray = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            GameBoard(TicTacToeArray);
            Player1(TicTacToeArray);
            Winner(TicTacToeArray);
            Player2(TicTacToeArray);
            Winner(TicTacToeArray);

            bool gamenotover = true;
            while (gamenotover)
            {
                GameBoard(TicTacToeArray);
                Player1(TicTacToeArray);
                Player2(TicTacToeArray);
                Winner(TicTacToeArray);
                gamenotover = Winner(TicTacToeArray);
                Console.WriteLine("game over");
                Console.ReadLine();
            }
        }

        static void GameBoard(string[] myArray)
        {
            Console.WriteLine("{0} {1} {2}", myArray[0], myArray[1], myArray[2]);
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2}", myArray[3], myArray[4], myArray[5]);
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2}", myArray[6], myArray[7], myArray[8]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("x goes first.");
            Console.WriteLine("y goes second");
            Console.WriteLine("pick a number to select a space.");
        }
        static bool Player1(string[] arrayinmethod)
        {
            string y = Console.ReadLine();
            int choice = Convert.ToInt32(y);
            arrayinmethod[choice] = "X";
            GameBoard(arrayinmethod);
            return true;

        }

        static bool Player2(string[] array2)
        {
            string x = Console.ReadLine();
            int choice2 = Convert.ToInt32(x);
            array2[choice2] = "O";
            GameBoard(array2);
            return true;
        }

        static bool Winner(string[] arrayinsidemethod4)
        {
            if (arrayinsidemethod4[0] == arrayinsidemethod4[1] && arrayinsidemethod4[1] == arrayinsidemethod4[2])
            {
                Console.WriteLine("winner");
                return true;
            }
            else if (arrayinsidemethod4[3] == arrayinsidemethod4[4] && arrayinsidemethod4[4] == arrayinsidemethod4[5])
            {
                Console.WriteLine("winner");
                return true;
            }
            else if (arrayinsidemethod4[6] == arrayinsidemethod4[7] && arrayinsidemethod4[7] == arrayinsidemethod4[8])
            {
                Console.WriteLine("winner");
                return true;
            }

            else if (arrayinsidemethod4[0] == arrayinsidemethod4[3] && arrayinsidemethod4[3] == arrayinsidemethod4[6])
            {
                Console.WriteLine("winner");
                return true;
            }
            else if (arrayinsidemethod4[1] == arrayinsidemethod4[4] && arrayinsidemethod4[4] == arrayinsidemethod4[7])
            {
                Console.WriteLine("winner");
                return true;
            }
            else if (arrayinsidemethod4[2] == arrayinsidemethod4[5] && arrayinsidemethod4[5] == arrayinsidemethod4[8])
            {
                Console.WriteLine("winner");
                return true;
            }
            else if (arrayinsidemethod4[0] == arrayinsidemethod4[4] && arrayinsidemethod4[4] == arrayinsidemethod4[8])
            {
                Console.WriteLine("winner");
                return true;
            }
            else if (arrayinsidemethod4[2] == arrayinsidemethod4[4] && arrayinsidemethod4[4] == arrayinsidemethod4[6])
            {
                Console.WriteLine("winner");
                return true;
            }
            else
            {
                return true;
            }
            return false;

        }
    }
}
