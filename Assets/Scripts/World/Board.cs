﻿using System;
using UnityEngine;

namespace Assets.Scripts.World
{
    public class Board
    {

        ///// Variables
        
        private int Columns;
        private int Rows;
        private Tile[,] _tiles;

        ///// Constructors

        public Board(Tile[,] tileArray)
        {
            Debug.Log("Board constructor :: [" + tileArray.GetLength(0)+"/"+tileArray.GetLength(1)+"]");
            Columns = tileArray.GetLength(0);
            Rows = tileArray.GetLength(1);
            _tiles = new Tile[Columns, Rows];
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    _tiles[column, row] = tileArray[column, row];
                }
            }
        }

        ///// Functions

        // Gets
        public Tile GetTile(int column, int row) { return _tiles[(column + Columns) % Columns, row]; }
        public int GetBoardDimensions(int index) { return _tiles.GetLength(index); }

        // Simple run-through (LowerLeft » UpperRight)
        public void ForEach(Action<Tile> action)
        {
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    action(_tiles[column, row]);
                }
            }
        }

        // Falling run-through (UpperLeft » LowerRight)
        public void ForEachWind(Action<Tile> action, float wind)
        {
            if (wind > 0)
            {
                for (var row = Rows - 1; row > 0; row--)
                {
                    for (var column = Columns - 1 ; column >= 0; column--)
                    {
                        action(_tiles[column, row]);
                    }
                }
            }
            else if (wind < 0)
            {
                for (var row = Rows - 1; row > 0; row--)
                {
                    for (var column = 0; column < Columns; column++)
                    {
                        action(_tiles[column, row]);
                    }
                }
            }
        }
    }
}