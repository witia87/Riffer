using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Views;
using Assets.Scripts.Systems;
using Assets.Scripts.World;

namespace Assets.Scripts.Engine
{
    public class Loader: MonoBehaviour
    {
        public GameObject boardManager;

        public readonly int FIXED_UPDATES_PER_TICK = 30;
        private static int FIXED_UPDATES_COUNTER = 0;
        
        private List<Mechanics> _mechanics = new List<Mechanics>();
        private Board _newBoard;

        void Start()
        {
            GameObject boardManagerGO = Instantiate(boardManager);
            _mechanics.Add(new Gravity());
            BoardManager.Instance.InitializeBoard();
            _newBoard = BoardManager.Instance.GetCurrentBoard();
        }

        public void ApplyMechanics(Board board)
        {
            foreach (var mechanic in _mechanics)
            {
                mechanic.Apply(board);
            }
        }

        void FixedUpdate()
        {
            if (FIXED_UPDATES_COUNTER == 0)
            {
                BoardManager.Instance.Redraw(_newBoard);
                var tempBoard = new Board(_newBoard);
                ApplyMechanics(tempBoard);
                _newBoard = tempBoard;
            }
            FIXED_UPDATES_COUNTER = (FIXED_UPDATES_COUNTER + 1) % FIXED_UPDATES_PER_TICK;
        }
    }
}