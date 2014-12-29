using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
    public class Pawn : ChessPiece
    {
        public Pawn(PieceColor color)
        {
            this._type = PieceType.Pawn;
            this._color = color;
        }

        /// <summary>
        /// Pawns can see the three squares in front of them: diagonal left, diagonal right, and straight ahead.
        /// </summary>
        public override void RevealVisibleSquares()
        {
            
            if (this._color == PieceColor.White)
            {
                int currentRank = this.Square.Rank;
                int currentFile = this.Square.File;
                ChessBoard board = this.Square.Board;
                if (currentRank < 7)
                {
                    if (currentFile == 0)
                    {
                        board.Grid[currentRank + 1][currentFile].Visible = true;
                        board.Grid[currentRank + 1][currentFile + 1].Visible = true;
                    }
                    else if (currentFile == 7)
                    {
                        board.Grid[currentRank + 1][currentFile].Visible = true;
                        board.Grid[currentRank + 1][currentFile - 1].Visible = true;
                    }
                    else
                    {
                        board.Grid[currentRank + 1][currentFile - 1].Visible = true;
                        board.Grid[currentRank + 1][currentFile].Visible = true;
                        board.Grid[currentRank + 1][currentFile + 1].Visible = true;
                    }
                }
            }
        }
    }
}
