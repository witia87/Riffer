using UnityEngine;

namespace Assets.Scripts.Gui
{
    public class GuiInventoryItem : MonoBehaviour
    {
        public int InventoryId;

        public Sprite MainSprite;

        private void Start()
        {
            name = "GuiInventoryItem " + InventoryId;
        }
    }
}