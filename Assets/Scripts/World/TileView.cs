using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    public class TileView : MonoBehaviour
    {
        ///// Variables
        public SubstanceId Substance;

        private Sprite sprite;

        ///// Functions
        public void RefreshSubstanceView(SubstanceId newSubstance)
        {
            Substance = newSubstance;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BoardManager.Instance.MapSprites[(int)newSubstance];
            //Debug.Log(name+" refreshed");
        }

        ///// MonoBehaviour Functions
        private void Awake()
        {
        }
    }
}
