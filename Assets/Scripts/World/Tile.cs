

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.InternalMath;

namespace Assets.Scripts.World
{
    public class Tile
    {
        ///// Variables
        public int Row { get; }
        public int Column { get; }
        public SubstanceId Substance { get;  set; }

        ///// Constructors

        public Tile(int column, int row, SubstanceId substance)
        {
            Row = row;
            Column = column;
            Substance = substance;
        }

        public Tile(Tile otherTile)
        {
            Row = otherTile.Row;
            Column = otherTile.Column;
            Substance = otherTile.Substance;
        }

        ///// Functions

        // Substance swap
        public void SwapSubstances(Tile other)
        {
            //Debug.Log(Substance+" swapped to "+ other.Substance+" @"+column+"/"+row);
            var newSubstanceId = other.Substance;
            other.Substance = this.Substance;
            Substance = newSubstanceId;

        }
    }
}