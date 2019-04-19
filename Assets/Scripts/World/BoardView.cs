using System;
using UnityEngine;

namespace Assets.Scripts.World
{
    public class BoardView
    {
        public static int Columns = 64;
        public static int Rows = 40;

        private TileView[,] _tileViews = new TileView[Columns, Rows];

        public BoardView(TileView[,] tileArray)
        {
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    _tileViews[column, row] = tileArray[column, row];
                }
            }
        }
        

        public TileView GetTileView(int column, int row)
        {
            return _tileViews[column, row];
        }

        public void ForEach(Action<TileView> action)
        {
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    action(_tileViews[column, row]);
                }
            }
        }
    }
}