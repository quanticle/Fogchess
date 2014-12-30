using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
    public class Knight : ChessPiece
    {
        public Knight(PieceColor color)
        {
            this._color = color;
            this._type = PieceType.Knight;
        }
        public override void RevealVisibleSquares()
        {
            throw new NotImplementedException();
        }
    }
}
