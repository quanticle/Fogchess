using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FogchessCore;

namespace FogchessCoreTests
{
    [TestClass]
    public class RookTests
    {
        [TestMethod]
        public void TestRookVisibilityCalculation_LowerLeftCorner_EmptyBoard()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[0][0].Piece = new Rook(PieceColor.White)
            {
                Square = board.Grid[0][0]
            };
            board.Grid[0][0].Piece.RevealVisibleSquares();
            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(true, board.Grid[i][0].Visible);
                Assert.AreEqual(true, board.Grid[0][i].Visible);
            }
        }

        [TestMethod]
        public void TestRookVisibilityCalculation_LowerRightCorner_EmptyBoard()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[0][7].Piece = new Rook(PieceColor.White)
            {
                Square = board.Grid[0][7]
            };
            board.Grid[0][7].Piece.RevealVisibleSquares();
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(true, board.Grid[i][7].Visible);
                Assert.AreEqual(true, board.Grid[0][i].Visible);
            }
        }

        [TestMethod]
        public void TestRookVisibilityCalculation_TopLeftCorner_EmptyBoard()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[7][0].Piece = new Rook(PieceColor.White)
            {
                Square = board.Grid[7][0]
            };
            board.Grid[7][0].Piece.RevealVisibleSquares();
            for (int i = 7; i >= 0; i--)
            {
                Assert.AreEqual(true, board.Grid[i][0].Visible);
                Assert.AreEqual(true, board.Grid[7][i].Visible);
            }
        }

        [TestMethod]
        public void TestRookVisibilityCalculation_TopRightCorner_EmptyBoard()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[7][7].Piece = new Rook(PieceColor.White)
            {
                Square = board.Grid[7][7]
            };
            board.Grid[7][7].Piece.RevealVisibleSquares();
            for (int i = 7; i >= 0; i--)
            {
                Assert.AreEqual(true, board.Grid[i][7].Visible);
                Assert.AreEqual(true, board.Grid[7][i].Visible);
            }
        }

        [TestMethod]
        public void TestRookVisibilityCalculation_Middle_EmptyBoard()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[4][4].Piece = new Rook(PieceColor.White)
            {
                Square = board.Grid[4][4]
            };
            board.Grid[4][4].Piece.RevealVisibleSquares();
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(true, board.Grid[i][4].Visible);
                Assert.AreEqual(true, board.Grid[4][i].Visible);
            }
        }
    }
}
