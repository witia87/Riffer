using Assets.Scripts.Systems;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Engine
{
    public class GameRunner: MonoBehaviour
    {
        private static readonly int FIXED_UPDATES_PER_TICK = 30;
        private static int FIXED_UPDATES_COUNTER = 0;

        private List<Mechanics> _mechanics = new List<Mechanics>();
        private Board _previousBoard;

        void Start()
        {
            _mechanics.Add(new Gravity());
            _previousBoard = new Board(GetInitialSubstanceDistribution());
            ViewModel.Board = _previousBoard;
        }

        private SubstanceId[,] GetInitialSubstanceDistribution()
        {
            var distribution = new SubstanceId[Board.HEIGHT, Board.WIDTH];
            for (var row = 0; row < Board.HEIGHT; row++)
            {
                for (var column = 0; column < Board.WIDTH; column++)
                {
                    distribution[row, column] =
                        GameObject.Find(String.Format(BoardView.FIELD_NAME_PATTERN, row, column)).GetComponent<FieldView>().InitialSubstanceId;
                }
            }

            return distribution;
        }


        void FixedUpdate()
        {
            if (FIXED_UPDATES_COUNTER == 0)
            {
                ViewModel.Board = _previousBoard;
                var board = new Board(_previousBoard);
                ApplyMechanics(board);
                _previousBoard = board;
            }
            FIXED_UPDATES_COUNTER = (FIXED_UPDATES_COUNTER + 1) % FIXED_UPDATES_PER_TICK;
        }

        public void ApplyMechanics(Board board)
        {
            foreach (var mechanic in _mechanics)
            {
                mechanic.Apply(board);
            }
        }
    }
}