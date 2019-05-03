using System;
using UnityEngine;
using Assets.Scripts.World;

namespace Assets.Scripts.Systems
{
    public class Wind: Mechanics
    {

        ///// Variables
        private float uniformWind = 0;
        private Board currentBoard = null;

        ///// Functions

        // Mechanics.Apply abstract override
        public override void Apply(Board board)
        {
            currentBoard = board;
            uniformWind = BoardManager.Instance.GetCurrentWind();
            board.ForEachWind(ApplyForTile, uniformWind);
        }

        // Single tile mechanics
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