using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.World;


namespace Assets.Scripts.Views
{/*
    public class ViewModel: MonoBehaviour
    {
        public static BoardOLD Board;
        private static Dictionary<SubstanceId, Sprite> _spritesDictionary;

        [Serializable]
        public struct SubstanceSprite
        {
            public SubstanceId id;
            public Sprite sprite;
        }
        [SerializeField] private SubstanceSprite[] _substanceSprites;

        private void Start()
        {
            InitializeDictionary();
        }

        public static Sprite GetSprite(SubstanceId id)
        {
            return _spritesDictionary[id];
        }

        public void InitializeDictionary()
        {
            _spritesDictionary = new Dictionary<SubstanceId, Sprite>();
            foreach (var substanceSprite in _substanceSprites)
            {
                _spritesDictionary.Add(substanceSprite.id, substanceSprite.sprite);
            }
        }
    }*/
}