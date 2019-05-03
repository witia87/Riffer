using System.Collections;
using System.Collections.Generic;
using UnityEngine;
﻿using Assets.Scripts.World.Substances;

namespace Assets.Scripts.World
{
    public class Tile
    {
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

        public int Row { get; }
        public int Column { get; }
        public SubstanceId Substance { get; set; }

        public void SwapSubstances(Tile other)
        {
            //Debug.Log(Substance+" swapped to "+ other.Substance+" @"+column+"/"+row);
            var newSubstanceId = other.Substance;
            other.Substance = Substance;
            Substance = newSubstanceId;
        }
    }
}