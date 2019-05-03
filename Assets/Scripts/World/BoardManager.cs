using System;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
=======
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Views;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor

namespace Assets.Scripts.World
{
    public class BoardManager : MonoBehaviour
    {

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public static BoardManager Instance = null;

        ///// Variables
        public Sprite[] MapSprites;
        public GameObject MapTilePrefab;
        public static GameObject BoardBag;

        private static int BOARD_COLUMNS = 64;
        private static int BOARD_ROWS = 40;
        private static float TILE_COLUMNS_SIZE = 0.25f;
        private static float TILE_ROWS_SIZE = 0.1875f;

        //private String boardSavedAsAlphanumericCode = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111331111111111111111111111111111111111111111111131111111111111111111111111111111111111111111111111111111111111111111111311111111111111111131111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111133111111131111111111111111133131111111111111111311111111113111113311111111111111311111111111111111111111111311111111111111111111111111111111111111111111111111111111111111111111111111111111113111111111111311111111111111111133311111111111111111111111111111311111111111111111111331111111113311111111111111111131111113111131111111111113111111111111111111331111111131313131111111111111111311111111111113111111111111111111111111111111111111111111111111311111111111111111111111111111131111111111111111111111111111111133111111131111111111111111111133311111111113111111111111111111133331111111311111111111111111111111111111111111111111111111111113333311111111111111333333111111111111111111111111111111111113111133333331111113333333333311113111313111311113113111311311113331133333331113331133333333331133333133313333333133113131311313333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333334443344334444334333333344333334333334433444433333333334433344334444344434444434443344344444333444444333333444443344444333344434444444444444444444433444444433444444443333444444444444443444444444444444444444444444444444444444444444444444444444445444444444444444445444444444444444444444444444444444444444444444444444444444444444446644444444444444444444444554444444446644444644466444466466446446666444464666444464466644666644446466644666444464466456666666666666666666666666666666666666666666666666666666666666666666666886666666666666566666666666666266666666666666666666666666666662266626666622668666666666666666226666666662666666666666626666622222622266662226662662662626666222226622662266266266566662226662222222222222222222222222222222222222822222222222222222225222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";
        private String boardSavedAsAlphanumericCode = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111131111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111311111111111111111111111111111111111111111111111111111111111111133111111111111111111111111111111111111111111111111111111111111133331111111111111111111111111111111111111111111111111111111111113333311111111111111111111111111111111111111111111111111111113333333333331111113333333333311113111313111311113113111311311133333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333334443344334444334333333344333334333334433444433333333334433344334444344434444434443344344444333444444333333444443344444333344434444444444444444444433444444433444444443333444444444444443444444444444444444444444444444444444444444444444444444444445444444444444444445444444444444444444444444444444444444444444444444444444444444444446644444444444444444444444554444444446644444644466444466466446446666444464666444464466644666644446466644666444464466456666666666666666666666666666666666666666666666666666666666666666666666886666666666666566666666666666266666666666666666666666666666662266626666622668666666666666666226666666662666666666666626666622222622266662226662662662626666222226622662266266266566662226662222222222222222222222222222222222222822222222222222222225222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";
        //private Board previousBoard;
        private Board _currentBoard;
        private BoardView _currentBoardVisual;
        private Tile[,] _tiles = new Tile[BOARD_COLUMNS, BOARD_ROWS];
        private TileView[,] _tileViews = new TileView[BOARD_COLUMNS, BOARD_ROWS];

        ///// Functions

        public void InitializeBoard()
        {
            BoardBag = new GameObject();
            BoardBag.name = "BoardBag";
=======
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor

        ///// Variables

        public static BoardManager Instance = null;

        [SerializeField] private float _currentWind = 0.0f;

        private int BOARD_COLUMNS;
        private int BOARD_ROWS;
        private static float TILE_COLUMNS_SIZE = 0.25f;
        private static float TILE_ROWS_SIZE = 0.1875f;

        private GameObject BoardTilesBag;
        private Board _currentBoard;
        private TileView[,] _tileViews;


        ///// Functions

        // .txt map reader
        public void InitializeBoardFromFile(String fileName)
        {
            /*
            Tile[,] _tiles = new Tile[BOARD_COLUMNS, BOARD_ROWS];
            string path = "Assets/Maps/"+ fileName+"map_test03.txt";

            StreamReader reader = new StreamReader(path);
            BOARD_COLUMNS = int.Parse(reader.ReadLine());
            BOARD_ROWS = int.Parse(reader.ReadLine());
            for (var lineNumber = 0; lineNumber < BOARD_ROWS; lineNumber++)
            {
                String oneLine = reader.ReadLine();
                for (var charNumber = 0; charNumber < BOARD_COLUMNS; charNumber++)
                {
                    SubstanceId _tempSubstance = (SubstanceId)(oneLine[charNumber] - 48);
                    _tiles[charNumber, lineNumber] = new Tile(charNumber, lineNumber, _tempSubstance);
                }
            }
            _currentBoard = new Board(_tiles);
            */
        }


        // Initialize Board
        public void InitializeTestBoardFromString(String boardSavedAsAlphanumericCode)
        {
            BOARD_COLUMNS = 64;
            BOARD_ROWS = 40;
            Tile[,] _tiles = new Tile[BOARD_COLUMNS, BOARD_ROWS];
            _tileViews = new TileView[BOARD_COLUMNS, BOARD_ROWS];

            BoardTilesBag = new GameObject();
            BoardTilesBag.name = "BoardTilesBag";
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
            for (var row = 0; row < BOARD_ROWS; row++)
            {
                for (var column = 0; column < BOARD_COLUMNS; column++) {
                    // Substance definer
                    int _tempStringIndex = ((BOARD_ROWS - 1 - row) * (BOARD_COLUMNS)) + column;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    SubstanceId _tempSubstance = (SubstanceId)(boardSavedAsAlphanumericCode[_tempStringIndex]-48);

                    // Making visual tile
                    MakeTileView(column, row, _tempSubstance);
                    // Tile/TiveView arrays
                    _tiles[column, row] = new Tile(row, column, _tempSubstance);
                }
            }
            _currentBoard = new Board(_tiles);
           // Redraw(_currentBoard);
        }

        public Board GetCurrentBoard() {
            return _currentBoard;
        }

        public void MakeTileView(int column, int row, SubstanceId initialSubstanceId) {
            GameObject _tempTileGameObject = Instantiate(MapTilePrefab);
            _tempTileGameObject.name = "Tile[" + column + "/" + row + "]";
            _tempTileGameObject.transform.SetParent(BoardBag.transform);
            _tempTileGameObject.transform.localPosition = new Vector3(TILE_COLUMNS_SIZE * column + (row % 2) * TILE_COLUMNS_SIZE / 2, TILE_ROWS_SIZE * row, 0);
            _tempTileGameObject.GetComponent<SpriteRenderer>().sprite = MapSprites[(int)initialSubstanceId];
            _tileViews[column, row] = _tempTileGameObject.GetComponent<TileView>();
            _tileViews[column, row].Substance = initialSubstanceId;
        }

        public void Redraw(Board board)
        {
            _currentBoard = new Board(_tiles);
=======
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
                    SubstanceId substanceFromBoardSavedAsAlphanumericCode = (SubstanceId)int.Parse(boardSavedAsAlphanumericCode.Substring(_tempStringIndex, 1));

                    // Tile
                    _tiles[column, row] = new Tile(column, row, substanceFromBoardSavedAsAlphanumericCode);
                    // Making visual tile
                    MakeTileView(column, row, substanceFromBoardSavedAsAlphanumericCode);
                }
            }
            Debug.Log("Making board ["+ _tiles.GetLength(0) + "/"+ _tiles.GetLength(1) + "]");
            _currentBoard = new Board(_tiles);
        }

        // Current board grabber
        public Board GetCurrentBoard()
        {
            return _currentBoard;
        }

        // Current wind grabber
        public float GetCurrentWind()
        {
            return _currentWind;
        }

        // TileView prefab factory 
        public void MakeTileView(int column, int row, SubstanceId initialSubstance)
        {
            //Debug.Log("MakeTileView :: "+column+"/"+row+" : "+initialSubstance);
            GameObject _tempTileGameObject = Instantiate(ViewModel.Instance.GetTileViewPrefab());
            _tempTileGameObject.name = "Tile[" + column + "/" + row + "]";
            _tempTileGameObject.transform.SetParent(BoardTilesBag.transform);
            _tempTileGameObject.transform.localPosition = new Vector3(TILE_COLUMNS_SIZE * column + (row % 2) * TILE_COLUMNS_SIZE / 2, TILE_ROWS_SIZE * row, 0);
            _tileViews[column, row] = _tempTileGameObject.GetComponent<TileView>();
            _tileViews[column, row].RefreshSubstanceView(initialSubstance);
        }

        // Redraws View (LowerLeft » UpperRight)
        public void Redraw()
        {
            // Debug.Log("redrawing _tileViews[" + _tileViews.GetLength(0) + "/"+ _tileViews.GetLength(1) + "] of BOARD["+ BOARD_COLUMNS +"/"+ BOARD_ROWS + "]");
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
            for (var row = 0; row < BOARD_ROWS; row++)
            {
                for (var column = 0; column < BOARD_COLUMNS; column++)
                {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    _tileViews[column, row].RefreshSubstanceView(_tiles[column, row].Substance);
                }
            }
            Debug.Log("redrawn");
        }

        ///// MonoBehaviour
=======
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
                    //Debug.Log("geting "+column+"/"+row+" ."+ _currentBoard.GetTile(column, row).Substance);
                    _tileViews[column, row].RefreshSubstanceView(_currentBoard.GetTile(column, row).Substance);
                }
            }
            //Debug.Log("redrawn");
        }


        ///// MonoBehaviour

        // Awake
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
=======
>>>>>>> parent of ab06775... Refactor
        void Awake()
        {
            if (Instance == null) Instance = this;
        }

    }
}