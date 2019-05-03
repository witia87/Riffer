using Assets.Scripts.World.Substances;
using UnityEngine;

namespace Assets.Scripts.World
{
    public class BoardFactory
    {
        public static Board CreateFromString(string boardSavedAsAlphanumericCode)
        {
            var columns = 64;
            var rows = 40;
            var _tiles = new Tile[columns, rows];

            for (var row = 0; row < rows; row++)
            for (var column = 0; column < columns; column++)
            {
                var _tempStringIndex = (rows - 1 - row) * columns + column;
                var substanceFromBoardSavedAsAlphanumericCode =
                    (SubstanceId) int.Parse(boardSavedAsAlphanumericCode.Substring(_tempStringIndex, 1));
                _tiles[column, row] = new Tile(column, row, substanceFromBoardSavedAsAlphanumericCode);
            }

            Debug.Log("Making board [" + _tiles.GetLength(0) + "/" + _tiles.GetLength(1) + "]");
            return new Board(_tiles);
        }
    }
}