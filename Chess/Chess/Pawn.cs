using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Pawn
    {
        const string WHITEPAWN = "P";
        const string BLACKPAWN = "p";

        //Drawing pawns on black and white squares on startup
        public void DrawStartup(string[,] arrPawnDraw, int SIZE)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int k = 0; k < SIZE; k++)
                {
                    if (i == 6 && k !=0){arrPawnDraw[i, k] = WHITEPAWN;}
                    else if (i== 1 && k !=0 ) { arrPawnDraw[i, k] = BLACKPAWN;}
                }
            }
        }

        public void MovePawn()
        {

        }
    }
}
