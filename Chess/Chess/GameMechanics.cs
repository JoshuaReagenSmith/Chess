using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class GameMechanics
    {
        const int SIZE = 9;
        
        

        //Controls
        BoardMechanics boardMechanic = new BoardMechanics();
        Pawn pawnPiece = new Pawn();

        //gettters

        public int getSize()
        {
            return SIZE;
        }
        
        //Checks to see whether it is a black of white square and returns true if white
        public bool GetSqaureColour(int i, int k)
        {
            return boardMechanic.CheckSqaure(i, k);
        }

        public void DrawPiecesStartup(string[,] arrBoard)
        {
            pawnPiece.DrawStartup(arrBoard, SIZE);
        }
    }
}
