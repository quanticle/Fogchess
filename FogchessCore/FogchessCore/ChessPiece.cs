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
    public abstract class ChessPiece
    {
        public PieceType Type
        {
            get;
            set;
        }

        public BoardSquare Square
        {
            get;
            set;
        }


        
    }
}
