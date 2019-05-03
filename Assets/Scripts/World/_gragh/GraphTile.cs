using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    public class GraphTile
    {
        ////////// Variables
        public SubstanceId Substance { get;  set; }

        public Dictionary<enumHexDirection, GraphTile> connections;

        ////////// Constructors

        public GraphTile()
        {
            Substance = SubstanceId.Vacuum;
            foreach (enumHexDirection direction in Enum.GetValues(typeof(enumHexDirection)))
            {
                connections[direction] = null;
            }
        }

        public GraphTile(GraphTile otherTile)
        {
            Substance = otherTile.Substance;
            foreach (enumHexDirection direction in Enum.GetValues(typeof(enumHexDirection)))
            {
                connections[direction] = otherTile.connections[direction];
            }
        }

        ////////// Functions

        //
        public static enumHexDirection ReversedHexDirection(enumHexDirection direction)
        {
            return (enumHexDirection)(5 - (int)direction);
        }

        //
        public GraphTile GetNeighbour(enumHexDirection neighbourTile)
        {
            return connections[neighbourTile];
        }

        //
        public void MakeConnection(GraphTile otherTile, enumHexDirection direction)
        {
            connections[direction] = otherTile;
            otherTile.connections[ReversedHexDirection(direction)] = this;
        }

        // Substance swap
        public void SwapSubstances(GraphTile otherTile)
        {
            //Debug.Log(Substance+" swapped to "+ other.Substance+" @"+column+"/"+row);
            var newSubstanceId = otherTile.Substance;
            otherTile.Substance = this.Substance;
            Substance = newSubstanceId;

        }
    }
}