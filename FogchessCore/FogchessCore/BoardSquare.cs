using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
    public class BoardSquare
    {
        public ChessPiece Piece
        {
            get;
            set;
        }

        public bool Visible
        {
            get;
            set;
        }

        public ChessBoard Board
        {
            get
            {
                return _board;
            }
        }

        private ChessBoard _board;

        public BoardSquare(ChessBoard board)
        {
            this._board = board;
        }
    }
}
