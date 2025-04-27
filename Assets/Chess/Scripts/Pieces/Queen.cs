using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class Queen : Straight_Diagonal_Piece
    {
        protected override void HighlightPosssibleMoves()
        {
            HighlightDiagonalCells();
            HighlightStraightCells();
        }
    }
}
