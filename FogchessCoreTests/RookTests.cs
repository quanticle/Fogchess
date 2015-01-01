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

        [TestMethod]
        public void TestRookVisibilityCalculation_BottomLeft_RankBlocked()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[0][0].Piece = new Rook(PieceColor.White)
            {
                Square = board.Grid[0][0]
            };
            board.Grid[0][3].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[0][3]
            };
            board.Grid[0][0].Piece.RevealVisibleSquares();
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(true, board.Grid[0][i].Visible);
            }
            for (int i = 3; i < 7; i++)
            {
                Assert.AreEqual(false, board.Grid[0][i].Visible);
            }
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(true, board.Grid[i][0].Visible);
            }

        }

        [TestMethod]
        public void TestRookVisibilityCalculation_BottomLeft_FileBlocked()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[0][0].Piece = new Rook(PieceColor.White)
            {
                Square = board.Grid[0][0]
            };
            board.Grid[2][0].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[2][0]
            };
            board.Grid[0][0].Piece.RevealVisibleSquares();
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(true, board.Grid[0][i].Visible);
            }
            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(true, board.Grid[i][0].Visible);
            }
            for (int i = 2; i < 7; i++)
            {
                Assert.AreEqual(false, board.Grid[i][0].Visible);
            }
        }

        [TestMethod]
        public void TestRookVisibilityCalculation_TopRight_RankBlocked()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[7][7].Piece = new Rook(PieceColor.Black)
            {
                Square = board.Grid[7][7]
            };
            board.Grid[7][6].Piece = new Pawn(PieceColor.White)
            {
                Square = board.Grid[7][6]
            };
            board.Grid[7][7].Piece.RevealVisibleSquares();
            for (int i = 7; i >= 0; i--)
            {
                Assert.AreEqual(true, board.Grid[i][7].Visible);
            }
            for (int i = 6; i >= 0; i--)
            {
                Assert.AreEqual(false, board.Grid[7][i].Visible);
            }
        }

        [TestMethod]
        public void TestRookVisibility_TopRight_FileBlocked()
        {
            ChessBoard board = new ChessBoard();
            board.Grid[7][7].Piece = new Rook(PieceColor.Black)
            {
                Square = board.Grid[7][7]
            };
            board.Grid[5][7].Piece = new Pawn(PieceColor.Black)
            {
                Square = board.Grid[5][7]
            };
            board.Grid[7][7].Piece.RevealVisibleSquares();
            for (int i = 7; i >= 0; i--)
            {
                Assert.AreEqual(true, board.Grid[7][i].Visible);
            }
            for (int i = 7; i >= 6; i--)
            {
                Assert.AreEqual(true, board.Grid[i][7].Visible);
            }
            for (int i = 5; i >= 0; i--)
            {
                Assert.AreEqual(false, board.Grid[i][5].Visible);
            }
        }
    }
}
