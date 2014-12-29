using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FogchessCore;

namespace FogchessCoreTests
{
    [TestClass]
    public class PawnTests
    {
        [TestMethod]
        public void TestVisibilityCalculation_LowerLeftCorner_White()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[1][0].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[1][0]
            };
            board.Grid[1][0].Piece.RevealVisibleSquares();
            Assert.AreEqual(true, board.Grid[2][0].Visible);
            Assert.AreEqual(true, board.Grid[2][1].Visible);

        }
    }
}
