using System;
using System.Collections.Generic;
using Assets.Scripts.World.Substances;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class ViewModel : MonoBehaviour
    {
        ///// Variables

        public static ViewModel Instance;

        private static Dictionary<SubstanceId, Sprite> _spritesDictionary;

        [SerializeField] private SubstanceSprite[] _substanceSprites = null;
        [SerializeField] private GameObject _tileViewPrefab = null;
        
        public static Sprite GetSprite(SubstanceId id)
        {
            return _spritesDictionary[id];
        }
        
        public GameObject GetTileViewPrefab()
        {
            return _tileViewPrefab;
        }
        
        public void InitializeDictionary()
        {
            _spritesDictionary = new Dictionary<SubstanceId, Sprite>();
            foreach (var substanceSprite in _substanceSprites)
                _spritesDictionary.Add(substanceSprite.id, substanceSprite.sprite);
        }
        
        private void Awake()
        {
            if (Instance == null) Instance = this;
            InitializeDictionary();
        }

        [Serializable]
        public struct SubstanceSprite
        {
            public SubstanceId id;
            public Sprite sprite;
        }
    }
}