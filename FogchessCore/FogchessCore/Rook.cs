using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogchessCore
{
    public class Rook : ChessPiece
    {
        public Rook(PieceColor color)
        {
            this._type = PieceType.Rook;
            this._color = color;
        }

        /// <summary>
        /// Rooks look straight ahead and to the left and right
        /// </summary>
        public override void RevealVisibleSquares()
        {
            int currentRank = this.Square.Rank;
            int currentFile = this.Square.File;
            ChessBoard board = this.Square.Board;
            this.Square.Board.Grid[currentRank][currentFile].Visible = true;

            //Reveal squares forward
            int revealedRank = currentRank + 1;
            while (revealedRank < 8 && board.Grid[revealedRank][currentFile].Piece == null)
            {
                board.Grid[revealedRank][currentFile].Visible = true;
                revealedRank++;
            }

            //Reveal squares backwards
            revealedRank = currentRank - 1;
            while (revealedRank >= 0 && board.Grid[revealedRank][currentFile].Piece == null)
            {
                board.Grid[revealedRank][currentFile].Visible = true;
                revealedRank--;
            }

            //Reveal squares left
            int revealedFile = currentFile - 1;
            while (revealedFile >= 0 && board.Grid[currentRank][revealedFile].Piece == null)
            {
                board.Grid[currentRank][revealedFile].Visible = true;
                revealedFile--;
            }

            //Reveal squares right
            revealedFile = currentFile + 1;
            while (revealedFile < 8 && board.Grid[currentRank][revealedFile].Piece == null)
            {
                board.Grid[currentRank][revealedFile].Visible = true;
                revealedFile++;
            }
        }
    }
}
