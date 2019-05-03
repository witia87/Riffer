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

            /// Base conditions
            if (tile.Substance == SubstanceId.Sand && /// Examined tiles substance must be an aggregate
                tile.Row > 1 && // Arbitral row restriction
                tile.Row < 39 && // Arbitral row restriction
                uniformWind != 0f) /// There must be a wind
            {
                /// Wind source tiles substance must be a wind medium
                if (currentBoard.GetTile(tile.Column - Math.Sign(uniformWind), tile.Row).Substance == SubstanceId.Atmo)
                {
                    /// Closest common neighbour
                    Tile neighbourTile = currentBoard.GetTile(tile.Column + Math.Sign(uniformWind), tile.Row);

                    // Wind strength above 1 mechanics
                    if (Mathf.Abs(uniformWind) >= 1)// && Mathf.Abs(uniformWind) < 3)
                    {
                        if (neighbourTile.Substance == SubstanceId.Atmo)
                        {
                            neighbourTile.SwapSubstances(tile);
                        }
                    }
                    /// Wind strength above 3 mechanics
                    if( Mathf.Abs(uniformWind) >= 3)
                    {
                        Tile farNeighbourTile = currentBoard.GetTile(tile.Column + (int)(1.5 * Math.Sign(uniformWind) + 0.5 * (tile.Row % 2 - 1)), tile.Row + 1);
                        if (neighbourTile.Substance == SubstanceId.Sand && farNeighbourTile.Substance == SubstanceId.Atmo)
                        {
                            farNeighbourTile.SwapSubstances(tile);
                        } /*else if (neighbourTile.Substance == SubstanceId.Atmo)
                        {
                            neighbourTile.SwapSubstances(tile);
                        }*/
                    }
                }
            }
        } // /ApplyForTile

    } // /class

} // /namespace
