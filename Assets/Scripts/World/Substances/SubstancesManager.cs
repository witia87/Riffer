using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;


namespace Assets.Scripts.World
{
    public enum SubstanceId
    {
        Vacuum, // 0
        Atmo,
        Permanite,
        Sand,
        Orthoclase, // 4
        Pyrite,
        Zircone,
        Composite,
        Corundum // 8
    }

    public enum SubstanceState
    {
        Nothing,
        Gas,
        Liquid,
        Aggregate,
        Solid,
        Permanent
    }

    [Serializable]
    public struct Substance
    {
        public SubstanceId id;
        public SubstanceState state;
        public float ro;
        public Sprite sprite;
        
    }

    public class SubstancesManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
