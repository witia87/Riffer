using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Views;

namespace Assets.Scripts.World
{
    public class BoardManager : MonoBehaviour
    {


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
            for (var row = 0; row < BOARD_ROWS; row++)
            {
                for (var column = 0; column < BOARD_COLUMNS; column++) {
                    // Substance definer
                    int _tempStringIndex = ((BOARD_ROWS - 1 - row) * (BOARD_COLUMNS)) + column;
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
            for (var row = 0; row < BOARD_ROWS; row++)
            {
                for (var column = 0; column < BOARD_COLUMNS; column++)
                {
                    //Debug.Log("geting "+column+"/"+row+" ."+ _currentBoard.GetTile(column, row).Substance);
                    _tileViews[column, row].RefreshSubstanceView(_currentBoard.GetTile(column, row).Substance);
                }
            }
            //Debug.Log("redrawn");
        }


        ///// MonoBehaviour

        // Awake
        void Awake()
        {
            if (Instance == null) Instance = this;
        }

    }
}