using System;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using Assets.Scripts;
=======
using UnityEngine;
>>>>>>> parent of ab06775... Refactor
=======
using UnityEngine;
>>>>>>> parent of ab06775... Refactor
=======
using UnityEngine;
>>>>>>> parent of ab06775... Refactor

namespace Assets.Scripts.World
{
    public class Board
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public static int Columns = 64;
        public static int Rows = 40;

        private Tile[,] _tiles = new Tile[Columns, Rows];

        public Board(Tile[,] tileArray)
        {
=======

        ///// Variables
        
        private int Columns;
        private int Rows;
        private Tile[,] _tiles;

        ///// Constructors

=======

        ///// Variables
        
        private int Columns;
        private int Rows;
        private Tile[,] _tiles;

        ///// Constructors

>>>>>>> parent of ab06775... Refactor
        public Board(Tile[,] tileArray)
        {
            Debug.Log("Board constructor :: [" + tileArray.GetLength(0)+"/"+tileArray.GetLength(1)+"]");
            Columns = tileArray.GetLength(0);
            Rows = tileArray.GetLength(1);
            _tiles = new Tile[Columns, Rows];
<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    _tiles[column, row] = tileArray[column, row];
                }
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
        
        public Board(Board otherBoard)
        {
            otherBoard.ForEach(tile => { _tiles[tile.Column, tile.Row] = new Tile(tile); });
        }
=======

        ///// Variables
        
        private int Columns;
        private int Rows;
        private Tile[,] _tiles;

        ///// Constructors
>>>>>>> parent of ab06775... Refactor

        public Board(Tile[,] tileArray)
        {
<<<<<<< HEAD
            return _tiles[column, row];
        }

=======
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
>>>>>>> parent of ab06775... Refactor
        public void ForEach(Action<Tile> action)
        {
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    action(_tiles[column, row]);
<<<<<<< HEAD
=======

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
=======

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
>>>>>>> parent of ab06775... Refactor
=======
                }
            }
        }

        // Falling run-through (UpperLeft » LowerRight)
        public void ForEachWind(Action<Tile> action, float wind)
        {
>>>>>>> parent of ab06775... Refactor
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
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
                }
            }
        }
    }
}