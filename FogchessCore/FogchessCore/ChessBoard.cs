using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
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
            for (int i = 0; i < 8; i++)
            {
                _grid[i] = new BoardSquare[8];
                for (int j = 0; j < 8; j++)
                {
                    _grid[i][j] = new BoardSquare(this)
                    {
                        Visible = false
                    };
                }
            }
        }
    }
}
