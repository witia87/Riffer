using System;
using Assets.Scripts;

namespace Assets.Scripts.World
{
    public class Board
    {
        public static int Columns = 64;
        public static int Rows = 40;

        private Tile[,] _tiles = new Tile[Columns, Rows];

        public Board(Tile[,] tileArray)
        {
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    _tiles[column, row] = tileArray[column, row];
                }
            }
        }
        
        public Board(Board otherBoard)
        {
            otherBoard.ForEach(tile => { _tiles[tile.Column, tile.Row] = new Tile(tile); });
        }

        public Tile GetTile(int column, int row)
        {
            return _tiles[column, row];
        }

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
    }
}