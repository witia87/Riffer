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

<<<<<<< HEAD
    public enum SubstanceId {
        Vacuum,
        Air,
        Sand,
        Stone,
        Rock,
        Pyrite,
        Zircone,
        Red
    }


=======
    
    ///// static MyMath class
>>>>>>> parent of ab06775... Refactor
    public static class MyMath
    {
        public static NodeDirections ReverseDirection(NodeDirections outDirection)
        {
            return 7 - outDirection;
        }
    }
}
