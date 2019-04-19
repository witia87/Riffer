using UnityEngine;
using System.Collections.Generic;
using Assets.Scripts.World;

namespace Assets.Scripts.Systems
{
    public class Gravity: Mechanics
    {

        private Board currentBoard = null;

        public override void Apply(Board board)
        {
            currentBoard = board;
            board.ForEach(ApplyForTile);
        }

        private void ApplyForTile(Tile tile)
        {
            if (tile.Substance == SubstanceId.Sand  && tile.Row > 0)
            {
                Tile otherTile = currentBoard.GetTile(tile.Column, tile.Row - 1);
                if (otherTile.Substance == SubstanceId.Atmo) {
                    Debug.Log("Swaping " + tile.Column + "/" + tile.Row + " " + tile.Substance + " » " + otherTile.Column + "/" + otherTile.Row + " " + otherTile.Substance );
                    otherTile.SwapSubstances(tile);
                    Debug.Log("Swaped " + tile.Column + "/" + tile.Row + " " + tile.Substance + " » " + otherTile.Column + "/" + otherTile.Row + " " + otherTile.Substance );
                }
            }
        }

    }

}