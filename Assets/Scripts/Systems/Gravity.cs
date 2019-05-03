using UnityEngine;
using System.Collections.Generic;
using Assets.Scripts.World;

namespace Assets.Scripts.Systems
{
    public class Gravity: Mechanics
    {

        ///// Variables
        private Board currentBoard = null;

        ///// Functions

        // Mechanics.Apply abstract override
        public override void Apply(Board board)
        {
            currentBoard = board;
            board.ForEach(ApplyForTile);
        }

        // Single tile mechanics
        private void ApplyForTile(Tile tile)
        {
            if (tile.Substance == SubstanceId.Sand && 
                tile.Row > 1 &&
                tile.Row < 39)
            {
                Tile lowerLeftTile = currentBoard.GetTile(tile.Column + tile.Row % 2 - 1, tile.Row - 1);
                Tile lowerRightTile = currentBoard.GetTile(tile.Column + tile.Row % 2, tile.Row - 1);
                Tile downTile = currentBoard.GetTile(tile.Column, tile.Row - 2);

                if (lowerLeftTile.Substance == SubstanceId.Atmo && 
                    lowerRightTile.Substance == SubstanceId.Atmo && 
                    downTile.Substance == SubstanceId.Atmo)
                {
                    downTile.SwapSubstances(tile);
                }
                else if (lowerLeftTile.Substance == SubstanceId.Atmo)
                {
                    lowerLeftTile.SwapSubstances(tile);
                }
                else if (lowerRightTile.Substance == SubstanceId.Atmo)
                {
                    lowerRightTile.SwapSubstances(tile);
                }
            }
        }

    }
}