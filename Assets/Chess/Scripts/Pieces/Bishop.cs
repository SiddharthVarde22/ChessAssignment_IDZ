using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class Bishop : Straight_Diagonal_Piece
    {
        protected override void HighlightPosssibleMoves()
        {
            HighlightDiagonalCells();
        }
    }
}
