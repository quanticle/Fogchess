using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
    /// <summary>
    /// Class that represents the chessboard. Use the Grid property to get the 2-d array of cells that 
    /// </summary>
    public class ChessBoard
    {
        private BoardSquare[][] _grid;
        public BoardSquare[][] Grid
        {
            get
            {
                return _grid;
            }
        }

        public ChessBoard()
        {
            _grid = new BoardSquare[8][];
            SquareColor leftmostColor = SquareColor.Black;
            for (int i = 0; i < 8; i++)
            {
                _grid[i] = new BoardSquare[8];
                SquareColor currentColor = leftmostColor;
                for (int j = 0; j < 8; j++)
                {
                    _grid[i][j] = new BoardSquare(this, i, j, currentColor)
                    {
                        Visible = false
                    };
                    currentColor = FlipSquareColor(currentColor);
                }
                leftmostColor = FlipSquareColor(leftmostColor);
            }
        }

        protected SquareColor FlipSquareColor(SquareColor color)
        {
            if (color == SquareColor.White)
            {
                return SquareColor.Black;
            }
            else
            {
                return SquareColor.White;
            }
        }
    }
}
