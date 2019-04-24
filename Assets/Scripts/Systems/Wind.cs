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
            
            if (tile.Substance == SubstanceId.Sand && 
                tile.Row > 1 && 
                tile.Row < 39 && 
                uniformWind != 0f)
            {

                if (Mathf.Abs(uniformWind) >= 1)
                {
                    Tile neighbourTile = currentBoard.GetTile(tile.Column + Math.Sign(uniformWind), tile.Row);
                    if (neighbourTile.Substance == SubstanceId.Atmo)
                    {
                        //Debug.Log(tile.Column+"/"+tile.Row+" : "+tile.Substance + " » "+neighbourTile.Column + "/" + neighbourTile.Row + " : " + neighbourTile.Substance);
                        neighbourTile.SwapSubstances(tile);

                    }

                }
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

        } // /ApplyForTile

    } // /class

} // /namespace