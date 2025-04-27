using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class King : ChessPlayerPlacementHandler
    {
        protected override void HighlightPosssibleMoves()
        {
            for(int i = row - 1; i <= row + 1; i++)
            {
                for(int j = column - 1; j <= column + 1; j++)
                {
                    if(i >= 0 && i < 8 && j >= 0 && j < 8)
                    {
                        if(PieceTracker.IsPlaceEmpty(i, j))
                        {
                            HighlightCell(i, j);
                        }
                    }
                }
            }
        }
    }
}
