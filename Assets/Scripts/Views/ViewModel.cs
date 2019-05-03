using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.World;


namespace Assets.Scripts.Views
{
    public class ViewModel: MonoBehaviour
    {
        [Serializable]
        public struct SubstanceSprite
        {
            public SubstanceId id;
            public Sprite sprite;
        }

        ///// Variables

        public static ViewModel Instance = null;

        [SerializeField] private SubstanceSprite[] _substanceSprites = null;
        [SerializeField] private GameObject TileViewPrefab = null;

        private static Dictionary<SubstanceId, Sprite> _spritesDictionary;

        ///// Functions

        // Sprite grabber from dictionary
        public static Sprite GetSprite(SubstanceId id)
        {
            return _spritesDictionary[id];
        }

        // Tile prefab grabber
        public GameObject GetTileViewPrefab()
        {
            return TileViewPrefab;
        }


        // Initialize Sprite dictionary
        public void InitializeDictionary()
        {
            _spritesDictionary = new Dictionary<SubstanceId, Sprite>();
            foreach (var substanceSprite in _substanceSprites)
            {
                _spritesDictionary.Add(substanceSprite.id, substanceSprite.sprite);
            }
        }

        ///// MonoBehaviour

        // Awake
        private void Awake()
        {
            if (Instance == null) Instance = this;
            InitializeDictionary();
        }
    }
}