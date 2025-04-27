using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Chess.Scripts.Core {
    public class ChessPlayerPlacementHandler : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] public int row, column;
        [SerializeField] protected PieceType m_pieceType;

        private void Start() {
            transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
            OnStart();
        }
        protected virtual void OnStart()
        {
            PieceTracker.AddPieceAt(row, column, m_pieceType);
        }
        protected virtual void HighlightPosssibleMoves() { }
        public void OnPointerDown(PointerEventData eventData)
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();
            HighlightPosssibleMoves();
        }
        protected void HighlightCell(int a_row, int a_column)
        {
            ChessBoardPlacementHandler.Instance.Highlight(a_row, a_column);
        }
    }
}