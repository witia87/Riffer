using System;
using UnityEngine;

namespace Assets.Scripts.World.Substances
{
    [Serializable]
    public struct Substance
    {
        public SubstanceId Id;
        public SubstanceState State;
        public float Ro;
        public Sprite Sprite;
    }
}