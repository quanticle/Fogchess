using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FogchessCore;

namespace FogchessCoreTests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void TestBoardColoration()
        {
            ChessBoard board = new ChessBoard();
            SquareColor leftColor = SquareColor.Black;
            SquareColor expectedColor;
            for (int i = 0; i < 8; i++)
            {
                expectedColor = leftColor;
                for (int j = 0; j < 8; j++)
                {
                    Assert.AreEqual(expectedColor, board.Grid[i][j].Color, String.Format("Square {0},{1} was the wrong color", i, j));
                    expectedColor = flipColor(expectedColor);
                }
                leftColor = flipColor(leftColor);
            }
        }

        private SquareColor flipColor(SquareColor color)
        {
            if (color == SquareColor.Black)
            {
                return SquareColor.White;
            }
            else
            {
                return SquareColor.Black;
            }
        }

        [TestMethod]
        public void TestBoardVisibility()
        {
            ChessBoard board = new ChessBoard();
            foreach(BoardSquare[] rank in board.Grid){
                foreach (BoardSquare square in rank)
                {
                    Assert.AreEqual(false, square.Visible);
                }
            }
        }
    }
}
