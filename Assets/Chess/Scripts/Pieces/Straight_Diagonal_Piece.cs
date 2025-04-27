using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class Straight_Diagonal_Piece : ChessPlayerPlacementHandler
    {
        protected virtual void HighlightStraightCells()
        {
            // Checking for cells in row - upwards
            for (int i = row + 1; i < 8; i++)
            {
                if (!PieceTracker.IsPlaceEmpty(i, column))
                {
                    break;
                }
                HighlightCell(i, column);
            }
            //Checking for cells in row - Downwards
            for (int i = row - 1; i >= 0; i--)
            {
                if (!PieceTracker.IsPlaceEmpty(i, column))
                {
                    break;
                }
                HighlightCell(i, column);
            }

            // Checking for cells in column - upwards
            for (int i = column + 1; i < 8; i++)
            {
                if (!PieceTracker.IsPlaceEmpty(row, i))
                {
                    break;
                }
                HighlightCell(row, i);
            }
            // Checking for cells in column - downwards
            for (int i = column - 1; i >= 0; i--)
            {
                if (!PieceTracker.IsPlaceEmpty(row, i))
                {
                    break;
                }
                HighlightCell(row, i);
            }
        }
        protected virtual void HighlightDiagonalCells()
        {
            // Checking upper right side
            for (int i = row - 1, j = column + 1; i >= 0 && j < 8; i--, j++)
            {
                if (!PieceTracker.IsPlaceEmpty(i, j))
                {
                    break;
                }
                HighlightCell(i, j);
            }

            // Checking upper left side
            for (int i = row + 1, j = column + 1; i < 8 && j < 8; i++, j++)
            {
                if (!PieceTracker.IsPlaceEmpty(i, j))
                {
                    break;
                }
                HighlightCell(i, j);
            }

            // Checking Lower right
            for (int i = row - 1, j = column - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (!PieceTracker.IsPlaceEmpty(i, j))
                {
                    break;
                }
                HighlightCell(i, j);
            }

            // Checking lower left
            for (int i = row + 1, j = column - 1; i < 8 && j >= 0; i++, j--)
            {
                if (!PieceTracker.IsPlaceEmpty(i, j))
                {
                    break;
                }
                HighlightCell(i, j);

            }
        }
    }
}
