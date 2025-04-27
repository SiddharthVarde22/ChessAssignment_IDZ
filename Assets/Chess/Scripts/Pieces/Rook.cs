using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class Rook : Straight_Diagonal_Piece
    {
        protected override void HighlightPosssibleMoves()
        {
            HighlightStraightCells();
        }
    }
}
