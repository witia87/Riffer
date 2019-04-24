using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.InternalMath
{

    // map tile node directions enum
    public enum NodeDirections
    {
        SELF, // 0
        RIGHT,
        LOWER_RIGHT,
        LOWER_LEFT,
        UPPER_RIGHT,
        UPPER_LEFT,
        LEFT
    }

    
    ///// static MyMath class
    public static class MyMath
    {
        public static NodeDirections ReverseDirection(NodeDirections outDirection)
        {
            return 7 - outDirection;
        }
    }
}
