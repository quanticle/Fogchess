using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FogchessCore;

namespace FogchessCoreTests
{
    [TestClass]
    public class PawnTests
    {
        [TestMethod]
        public void TestPawnVisibilityCalculation_LowerLeftCorner_White()
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

        [TestMethod]
        public void TestPawnVisibilityCalculation_LowerRightCorner_White()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[1][7].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[1][7]
            };
            board.Grid[1][7].Piece.RevealVisibleSquares();
            Assert.AreEqual(true, board.Grid[2][7].Visible);
            Assert.AreEqual(true, board.Grid[2][6].Visible);
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_Center_White()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[3][4].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[3][4]
            };
            board.Grid[3][4].Piece.RevealVisibleSquares();
            Assert.AreEqual(true, board.Grid[4][3].Visible);
            Assert.AreEqual(true, board.Grid[4][4].Visible);
            Assert.AreEqual(true, board.Grid[4][5].Visible);
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_TopLeftCorner_White()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[7][0].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[7][0]
            };
            board.Grid[7][0].Piece.RevealVisibleSquares();
            Assert.AreEqual(false, board.Grid[6][0].Visible);
            Assert.AreEqual(false, board.Grid[6][1].Visible);
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_TopRightCorner_White()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[7][7].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[7][7]
            };
            board.Grid[7][7].Piece.RevealVisibleSquares();
            Assert.AreEqual(false, board.Grid[6][7].Visible);
            Assert.AreEqual(false, board.Grid[6][6].Visible);
            
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_TopLeftCorner_Black()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[6][0].Piece = new Pawn(PieceColor.Black)
            {
                Square = board.Grid[6][0]
            };
            board.Grid[6][0].Piece.RevealVisibleSquares();
            Assert.AreEqual(true, board.Grid[5][0].Visible);
            Assert.AreEqual(true, board.Grid[5][1].Visible);
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_TopRightCorner_Black()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[6][7].Piece = new Pawn(PieceColor.Black)
            {
                Square = board.Grid[6][7]
            };
            board.Grid[6][7].Piece.RevealVisibleSquares();
            Assert.AreEqual(true, board.Grid[5][6].Visible);
            Assert.AreEqual(true, board.Grid[5][7].Visible);
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_LowerLeftCorner_Black()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[0][0].Piece = new Pawn(PieceColor.Black)
            {
                Square = board.Grid[0][0]
            };
            board.Grid[0][0].Piece.RevealVisibleSquares();
            Assert.AreEqual(false, board.Grid[1][0].Visible);
            Assert.AreEqual(false, board.Grid[1][1].Visible);
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_LowerRightCorner_Black()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[0][7].Piece = new Pawn(PieceColor.Black)
            {
                Square = board.Grid[0][7]
            };
            board.Grid[0][7].Piece.RevealVisibleSquares();
            Assert.AreEqual(false, board.Grid[1][7].Visible);
            Assert.AreEqual(false, board.Grid[1][6].Visible);
        }

        [TestMethod]
        public void TestPawnVisibilityCalculation_Center_Black()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[4][3].Piece = new Pawn(PieceColor.Black)
            {
                Square = board.Grid[4][3]
            };
            board.Grid[4][3].Piece.RevealVisibleSquares();
            Assert.AreEqual(true, board.Grid[3][2].Visible);
            Assert.AreEqual(true, board.Grid[3][3].Visible);
            Assert.AreEqual(true, board.Grid[3][4].Visible);
            
        }

        [TestMethod]
        public void TestPawnOwnSquareVisibility()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[4][3].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[4][3]
            };
            board.Grid[4][3].Piece.RevealVisibleSquares();
            Assert.AreEqual(true, board.Grid[4][3].Visible);
        }
    }
}
