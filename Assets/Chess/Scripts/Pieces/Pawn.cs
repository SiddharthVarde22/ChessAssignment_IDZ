using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Chess.Scripts.Core
{
    public class Pawn : ChessPlayerPlacementHandler, IPointerDownHandler
    {
        bool m_isFirtsMove = true;
        protected override void HighlightPosssibleMoves()
        {
            int l_row = row, l_column = column, l_moves = m_isFirtsMove ? 2 : 1;
            for (int i = 0; i < l_moves; i++)
            {
                l_row++;
                if (PieceTracker.IsPlaceEmpty(l_row, l_column))
                {
                    HighlightCell(l_row, l_column);
                }
            }
        }

    }
}
