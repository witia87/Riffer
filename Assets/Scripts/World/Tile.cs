

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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        //private Tile[] node;

        ///// Constructors
        public Tile(int row, int column, SubstanceId substance)
=======
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
        ///// Constructors

        public Tile(int column, int row, SubstanceId substance)
>>>>>>> parent of ab06775... Refactor
        {
            Row = row;
            Column = column;
            Substance = substance;
            //node = new Tile[7];
            //for (int i = 0; i < 7; i++) { node[i] = null; }
        }

        public Tile(Tile otherTile)
        {
            Row = otherTile.Row;
            Column = otherTile.Column;
            Substance = otherTile.Substance;
        }

        ///// Functions
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        /*
        public void MakeNodeConnection(Tile other, NodeDirections direction)
        {
            node[(int)direction] = other;
            other.node[7 - (int)direction] = this;
        }
        

        public void AddForce() { }
        */
=======

        // Substance swap
>>>>>>> parent of ab06775... Refactor
=======

        // Substance swap
>>>>>>> parent of ab06775... Refactor
=======

        // Substance swap
>>>>>>> parent of ab06775... Refactor
        public void SwapSubstances(Tile other)
        {
            Debug.Log(Substance+" swapped to "+ other.Substance);
            var newSubstanceId = other.Substance;
            other.Substance = this.Substance;
            Substance = newSubstanceId;

        }
    }
}