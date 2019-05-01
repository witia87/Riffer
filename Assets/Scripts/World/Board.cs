using System;

namespace Assets.Scripts.World
{
    public class Board
    {
        public static Board Current;
        private readonly Tile[,] _tiles;

        public readonly int Columns = 64;
        public readonly int Rows = 40;

        public Board(Tile[,] tiles)
        {
            Columns = tiles.GetLength(0);
            Rows = tiles.GetLength(1);
            _tiles = tiles;
        }

        public Tile GetTile(int column, int row)
        {
            return _tiles[(column + Columns) % Columns, row];
        }

        public int GetBoardDimensions(int index)
        {
            return _tiles.GetLength(index);
        }

        public void ForEach(Action<Tile> action, VerticalDirection verticalDirection,
            HorizontalDirection horizontalDirection)
        {
            if (verticalDirection == VerticalDirection.Up)
                for (var row = Rows - 1; row > 0; row--)
                    ForEachInRow(row, action, horizontalDirection);
            else if (verticalDirection == VerticalDirection.Down)
                for (var row = Rows - 1; row > 0; row--)
                    ForEachInRow(row, action, horizontalDirection);
        }

        private void ForEachInRow(int row, Action<Tile> action, HorizontalDirection horizontalDirection)
        {
            if (horizontalDirection == HorizontalDirection.Right)
                for (var column = 0; column < Columns; column++)
                    action(_tiles[column, row]);
            else if (horizontalDirection == HorizontalDirection.Left)
                for (var column = Columns - 1; column >= 0; column--)
                    action(_tiles[column, row]);
        }
    }
}