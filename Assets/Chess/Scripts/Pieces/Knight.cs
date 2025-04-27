using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class Knight : ChessPlayerPlacementHandler
    {
        protected override void HighlightPosssibleMoves()
        {
            CheckAndHighlight(row + 2, column + 1);
            CheckAndHighlight(row + 2, column - 1);
            CheckAndHighlight(row - 2, column + 1);
            CheckAndHighlight(row - 2, column - 1);
            CheckAndHighlight(row + 1, column + 2);
            CheckAndHighlight(row - 1, column + 2);
            CheckAndHighlight(row + 1, column - 2);
            CheckAndHighlight(row - 1, column - 2);
        }

        private void CheckAndHighlight(int a_row, int a_column)
        {
            if(a_row >= 0 && a_row < 8 && a_column >= 0 && a_column < 8 && PieceTracker.IsPlaceEmpty(a_row, a_column))
            {
                HighlightCell(a_row, a_column);
            }
        }
    }
}
