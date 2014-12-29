using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
    public enum SquareColor
    {
        Black,
        White
    }
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

        protected int _rank;

        public int Rank
        {
            get
            {
                return _rank;
            }
        }

        protected int _file;

        public int File
        {
            get
            {
                return _file;
            }
        }

        protected SquareColor _color;

        public SquareColor Color
        {
            get
            {
                return _color;
            }
        }

        protected ChessBoard _board;

        public BoardSquare(ChessBoard board, int rank, int file, SquareColor color)
        {
            this._board = board;
            this._rank = rank;
            this._file = file;
            this._color = color;
        }
    }
}
