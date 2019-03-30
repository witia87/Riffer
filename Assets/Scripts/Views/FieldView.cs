using System.Runtime.ConstrainedExecution;
using UnityEngine;

namespace Assets.Scripts
{
    public class FieldView: MonoBehaviour
    {
        [SerializeField] private int _row, _column;
        private SubstanceId _substanceId;
        private SpriteRenderer _renderer;

        public SubstanceId InitialSubstanceId;

        public void SetPosition(int row, int column)
        {
            _row = row;
            _column = column;
        }

        void Start()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _substanceId = ViewModel.Board.GetField(_row, _column).SubstanceId;
            _renderer.sprite = ViewModel.GetSprite(_substanceId);
        }

        void Update()
        {
            if (_substanceId != ViewModel.Board.GetField(_row, _column).SubstanceId)
            {
                _substanceId = ViewModel.Board.GetField(_row, _column).SubstanceId;
                _renderer.sprite = ViewModel.GetSprite(_substanceId);
            }
        }

        void OnValidate()
        {
            FindObjectOfType<ViewModel>().InitializeDictionary();
            GetComponent<SpriteRenderer>().sprite = ViewModel.GetSprite(InitialSubstanceId);
        }
    }
}