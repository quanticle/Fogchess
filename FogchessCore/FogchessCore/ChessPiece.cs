using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
    public enum PieceType
    {
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }

    public enum PieceColor
    {
        Black,
        White
    }

    public abstract class ChessPiece
    {
        protected PieceType _type;
        public PieceType Type
        {
            get
            {
                return _type;
            }
        }

        protected PieceColor _color;
        public PieceColor Color
        {
            get
            {
                return _color;
            }
        }

        public BoardSquare Square
        {
            get;
            set;
        }

        public abstract void RevealVisibleSquares();
        
    }
}
