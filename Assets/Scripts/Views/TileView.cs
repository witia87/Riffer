using Assets.Scripts.World;
using Assets.Scripts.World.Substances;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class TileView : MonoBehaviour
    {
        public int Column;
        public int Row;

        private SpriteRenderer _spriteRenderer;
        public SubstanceId Substance = SubstanceId.Vacuum;

        public void Update()
        {
            var newSubstance = Board.Current.GetTile(Column, Row).Substance;
            if (newSubstance != Substance)
            {
                Substance = newSubstance;
                _spriteRenderer.sprite = ViewModel.GetSprite(newSubstance);
            }
        }

        private void Awake()
        {
            _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            _spriteRenderer.sprite = ViewModel.GetSprite(SubstanceId.Vacuum);
        }
    }
}