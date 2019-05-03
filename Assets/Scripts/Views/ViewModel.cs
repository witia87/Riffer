using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.World;


namespace Assets.Scripts.Views
<<<<<<< HEAD
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
=======
{
    public class ViewModel: MonoBehaviour
    {
        [Serializable]
        public struct SubstanceSprite
        {
            public SubstanceId id;
            public Sprite sprite;
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of ab06775... Refactor

        ///// Variables
=======

<<<<<<< HEAD
        ///// Variables
=======
        public static ViewModel Instance = null;

        [SerializeField] private SubstanceSprite[] _substanceSprites = null;
        [SerializeField] private GameObject TileViewPrefab = null;
>>>>>>> parent of ab06775... Refactor

        public static ViewModel Instance = null;

<<<<<<< HEAD
        [SerializeField] private SubstanceSprite[] _substanceSprites = null;
        [SerializeField] private GameObject TileViewPrefab = null;
>>>>>>> parent of ab06775... Refactor

        public static ViewModel Instance = null;

<<<<<<< HEAD
        [SerializeField] private SubstanceSprite[] _substanceSprites = null;
        [SerializeField] private GameObject TileViewPrefab = null;
>>>>>>> parent of ab06775... Refactor

        private void Start()
        {
            InitializeDictionary();
        }

<<<<<<< HEAD
=======
        ///// Functions

        // Sprite grabber from dictionary
>>>>>>> parent of ab06775... Refactor
=======
        ///// Functions

        // Sprite grabber from dictionary
>>>>>>> parent of ab06775... Refactor
=======
        ///// Functions

        // Sprite grabber from dictionary
>>>>>>> parent of ab06775... Refactor
        public static Sprite GetSprite(SubstanceId id)
        {
            return _spritesDictionary[id];
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
        // Tile prefab grabber
        public GameObject GetTileViewPrefab()
        {
            return TileViewPrefab;
        }


        // Initialize Sprite dictionary
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
        public void InitializeDictionary()
        {
            _spritesDictionary = new Dictionary<SubstanceId, Sprite>();
            foreach (var substanceSprite in _substanceSprites)
            {
                _spritesDictionary.Add(substanceSprite.id, substanceSprite.sprite);
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    }*/
=======
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor

        ///// MonoBehaviour

        // Awake
        private void Awake()
        {
            if (Instance == null) Instance = this;
            InitializeDictionary();
        }
    }
>>>>>>> parent of ab06775... Refactor
}