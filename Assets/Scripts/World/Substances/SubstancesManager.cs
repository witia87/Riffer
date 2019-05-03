<<<<<<< HEAD
<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
=======
﻿using System;
using System.Collections.Generic;
using System.Collections;
>>>>>>> parent of ab06775... Refactor
=======
﻿using System;
using System.Collections.Generic;
using System.Collections;
>>>>>>> parent of ab06775... Refactor
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

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of ab06775... Refactor
    [Serializable]
    public struct Substance
    {
        public SubstanceId id;
        public SubstanceState state;
        public float ro;
        public Sprite sprite;
        
    }

<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
    public class SubstancesManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
<<<<<<< HEAD
<<<<<<< HEAD

=======
           
>>>>>>> parent of ab06775... Refactor
=======
           
>>>>>>> parent of ab06775... Refactor
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
