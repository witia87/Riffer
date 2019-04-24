using UnityEngine;
using Assets.Scripts.World;

namespace Assets.Scripts.Views
{
    public class TileView : MonoBehaviour
    {
        ///// Variables
        [SerializeField] private SubstanceId Substance = SubstanceId.Vacuum;

        private SpriteRenderer spriteRenderer;

        ///// Functions
        public void RefreshSubstanceView(SubstanceId newSubstance)
        {
            Substance = newSubstance;
            spriteRenderer.sprite = ViewModel.GetSprite(newSubstance);
            //Debug.Log(name+" refreshed");
        }

        ///// MonoBehaviour Functions
        private void Awake()
        {
            spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = ViewModel.GetSprite(SubstanceId.Vacuum);
        }
    }
}
