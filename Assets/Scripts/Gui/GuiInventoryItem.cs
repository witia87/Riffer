using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Gui
{
    public class GuiInventoryItem : MonoBehaviour {

        public Sprite mainSprite;
        public int inventoryId;

        // Start
        void Start() {
            name = "GuiInventoryItem " + inventoryId;
        }

    }
}