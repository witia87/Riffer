using Assets.Scripts.World;
using Assets.Scripts.World.Substances;

namespace Assets.Scripts.Mechanics
{
    public class Gravity : CellularMechanics
    {
        private Board _currentBoard;

        public override void Apply(Board board)
        {
            _currentBoard = board;
            board.ForEach(ApplyForTile, VerticalDirection.Up, HorizontalDirection.Right);
        }

        private void ApplyForTile(Tile tile)
        {
            if (tile.Substance == SubstanceId.Sand &&
                tile.Row > 1 &&
                tile.Row < 39)
            {
                var lowerLeftTile = _currentBoard.GetTile(tile.Column + tile.Row % 2 - 1, tile.Row - 1);
                var lowerRightTile = _currentBoard.GetTile(tile.Column + tile.Row % 2, tile.Row - 1);
                var downTile = _currentBoard.GetTile(tile.Column, tile.Row - 2);

                if (lowerLeftTile.Substance == SubstanceId.Atmo && lowerRightTile.Substance == SubstanceId.Atmo &&
                    downTile.Substance == SubstanceId.Atmo)
                    downTile.SwapSubstances(tile);
                else if (lowerLeftTile.Substance == SubstanceId.Atmo)
                    lowerLeftTile.SwapSubstances(tile);
                else if (lowerRightTile.Substance == SubstanceId.Atmo) lowerRightTile.SwapSubstances(tile);
            }
        }
    }
}