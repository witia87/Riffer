using Assets.Scripts.World;
using Assets.Scripts.World.Substances;

namespace Assets.Scripts.Mechanics
{
    public class Wind : CellularMechanics
    {
        private readonly HorizontalDirection _windDirection = HorizontalDirection.Right;
        private readonly float _windStrength = 1;
        private Board _currentBoard;

        public override void Apply(Board board)
        {
            _currentBoard = board;
            board.ForEach(ApplyForTile, VerticalDirection.Up, _windDirection);
        }

        private void ApplyForTile(Tile tile)
        {
            if (tile.Substance == SubstanceId.Sand &&
                tile.Row > 1 &&
                tile.Row < 39 &&
                _windStrength > 0f)
            {
                var horizontalOffset = _windDirection == HorizontalDirection.Right ? 1 : -1;
                var neighbourTile = _currentBoard.GetTile(tile.Column + horizontalOffset, tile.Row);
                if (neighbourTile.Substance == SubstanceId.Atmo)
                    //Debug.Log(tile.Column+"/"+tile.Row+" : "+tile.Substance + " » "+neighbourTile.Column + "/" + neighbourTile.Row + " : " + neighbourTile.Substance);
                    neighbourTile.SwapSubstances(tile);
                /*
                // LEFT WIND
                if (uniformWind <= -1)
                {
                    Tile leftTile = currentBoard.GetTile(tile.Column - 1, tile.Row);
                    Tile farLeftTile = currentBoard.GetTile(tile.Column - 2, tile.Row);
                    Tile upperLeftTile = currentBoard.GetTile(tile.Column + tile.Row % 2 - 1, tile.Row + 1);
                    Tile farUpperLeftTile = currentBoard.GetTile(tile.Column + tile.Row % 2 - 2, tile.Row + 1);
                    if (leftTile.Substance == SubstanceId.Atmo)
                    {
                        leftTile.SwapSubstances(tile);
                    }
                }

                // RIGHT WIND
                if (uniformWind >= 1)
                {
                    Tile rightTile = currentBoard.GetTile(tile.Column + 1, tile.Row);
                    Tile farRightTile = currentBoard.GetTile(tile.Column + 2, tile.Row);
                    Tile upperRightTile = currentBoard.GetTile(tile.Column + tile.Row % 2, tile.Row + 1);
                    Tile farUpperRightTile = currentBoard.GetTile(tile.Column + tile.Row % 2 + 1, tile.Row + 1);
                    if (uniformWind >= 4)
                    {

                        if (upperRightTile.Substance == SubstanceId.Atmo)
                        {
                            upperRightTile.SwapSubstances(tile);

                        }
                    }
                    if (rightTile.Substance == SubstanceId.Atmo)
                    {
                        tile.SwapSubstances(rightTile);

                    }
                    
                }*/
            }
        }
    }
}