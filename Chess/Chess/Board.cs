using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Board
    {
        //consts
        const string LETTERS = "ABCDEFGH";

        //globals
            //bools
            bool hasBegun = false;

        //2d arrays
        //i is row, k is colum
        //88
        String[,] board = new string[9,9];
        string[,] boardASNotation = new string[9, 9];

        //Objects
        GameMechanics mechanicController = new GameMechanics();

        void Fill()
        {
            FillDisplayCore();
        }

        void FillStartup()
        {
            FillDisplayCore();
            mechanicController.DrawPiecesStartup(board);
        }

        void FillDisplayCore()
        {
            int temp = 9;
            for (int i = 0; i < mechanicController.getSize(); i++)
            {temp--;
                for (int k = 0; k < mechanicController.getSize(); k++)
                {//filling up for chess notation
                    if (k-1 >= 0) { boardASNotation[i, k] = LETTERS[k-1] + temp.ToString(); }
                    else{ boardASNotation[i, k] = LETTERS[k].ToString() + temp.ToString(); }

                    if (i == 8 && k != 0) { board[i, k] = LETTERS[k - 1].ToString(); boardASNotation[i, k] = "/"; }
                    else if (i != 8 && k == 0) { board[i, k] = temp.ToString(); boardASNotation[i, k] = "/"; }
                    else if (mechanicController.GetSqaureColour(i,k) && k !=0 && i!= 8) { board[i, k] = "·"; }//White 72,74
                    else if (!mechanicController.GetSqaureColour(i, k) && i != 8 && k!=0) { board[i, k] = "@"; }//Black 71, 73
                    else { board[i, k] = "*"; boardASNotation[i, k] = "/"; }
                }
            }
        }

        public void DrawBoard()
        {
            if (!hasBegun){FillStartup(); hasBegun = true;}
            else{Console.Clear();Fill();}

            for (int i = 0; i < mechanicController.getSize(); i++)
            {
                for (int k = 0; k < mechanicController.getSize(); k++)
                {
                    Console.Write(board[i,k] +"  ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
