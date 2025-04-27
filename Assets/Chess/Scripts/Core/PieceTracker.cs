using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class PieceTracker : MonoBehaviour
    {
        private static PieceTracker s_instance;

        private PieceType[,] m_piecePositions = new PieceType[8, 8];

        private void Awake()
        {
            s_instance = this;
        }
        private void OnDestroy()
        {
            s_instance = null;
        }

        public static void AddPieceAt(int a_row, int a_cloumn, PieceType a_pieceType)
        {
            s_instance.m_piecePositions[a_row, a_cloumn] = a_pieceType;
        }
        public static void RemovePieceFrom(int a_row, int a_column, PieceType a_pieceType)
        {
            s_instance.m_piecePositions[a_row, a_column] = a_pieceType;
        }
        public static bool IsPlaceEmpty(int a_row, int a_column)
        {
            return s_instance.m_piecePositions[a_row, a_column] == PieceType.None;
        }
    }
}
