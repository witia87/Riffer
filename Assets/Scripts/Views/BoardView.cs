using Assets.Scripts.World;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class BoardView : MonoBehaviour
    {
        private static readonly float TileColumnsSize = 0.25f;
        private static readonly float TileRowsSize = 0.1875f;

        public void Start()
        {
            Board.Current.ForEach(MakeTileView, VerticalDirection.Up, HorizontalDirection.Right);
        }

        public void MakeTileView(Tile tile)
        {
            var tempTileGameObject = Instantiate(ViewModel.Instance.GetTileViewPrefab());
            tempTileGameObject.name = "Tile[" + tile.Column + "/" + tile.Row + "]";
            tempTileGameObject.transform.SetParent(transform);
            tempTileGameObject.transform.localPosition = new Vector3(
                TileColumnsSize * tile.Column + tile.Row % 2 * TileColumnsSize / 2, TileRowsSize * tile.Row, 0);
            var tileView = tempTileGameObject.GetComponent<TileView>();
            tileView.Row = tile.Row;
            tileView.Column = tile.Column;
        }
    }
}