﻿using System;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Views;
using Assets.Scripts.Systems;
using Assets.Scripts.World;

namespace Assets.Scripts.Engine
{
    public class Loader: MonoBehaviour
    {
        ///// Variables

        //public GameObject boardManager;

        public int BEAT_NO = 0;
        [SerializeField] private int FixedUpdateTicksPerBeat = 31;
        private int FixedUpdateTicksCounter = 0;
        
        private List<Mechanics> _mechanics = new List<Mechanics>();

        ///// Functions

        //
        public void ApplyMechanics(Board board)
        {
            foreach (var mechanic in _mechanics)
            {
                mechanic.Apply(board);
            }
        }

        ///// MonoBehaviour
        
        // Start
        void Start()
        {
            //String map_test03 = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111131111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111133333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333334443344334444334333333344333334333334433444433333333334433344334444344434444434443344344444333444444333333444443344444333344434444444444444444444433444444433444444443333444444444444443444444444444444444444444444444444444444444444444444444444445444444444444444445444444444444444444444444444444444444444444444444444444444444444446644444444444444444444444554444444446644444644466444466466446446666444464666444464466644666644446466644666444464466456666666666666666666666666666666666666666666666666666666666666666666666886666666666666566666666666666266666666666666666666666666666662266626666622668666666666666666226666666662666666666666626666622222622266662226662662662626666222226622662266266266566662226662222222222222222222222222222222222222822222222222222222225222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";
            String map_test02 = "1111111111111111111111111111111111111111111111111111111111111111111113111111111111311111311111111111111111311111111111311111131111111311111111113111111111111111311111111111311111111311111111111111111111111111111111111111111311111111111113111111113131111111111111311111131113111111111311111111111331111111111111111111111111111111111111111113311111111113111311111111113111111131111111111111111111111111113111111111111111111111111111111111111111111111111111111111111131111111111111131131111331111111111111311111111111113113111111131111111111311111111111111111111111111111111111111111111111111111111111311111111111111111311111131111111111111111111111111111111111111111111111311111111111111111111111111131111111111111111111111111111111111111111111111111111111111111111111111111111311111111111111111111111111111111111111111111111111111111111111133111111111111111111111111111111111111111111111111111111111111133331111111111111113111111111111111111111111111111111111111111113333311111111111111111111111111111111111111111111111111111113333333333331111113333333333311113111313111311113113111311311133333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333334443344334444334333333344333334333334433444433333333334433344334444344434444434443344344444333444444333333444443344444333344434444444444444444444433444444433444444443333444444444444443444444444444444444444444444444444444444444444444444444444445444444444444444445444444444444444444444444444444444444444444444444444444444444444446644444444444444444444444554444444446644444644466444466466446446666444464666444464466644666644446466644666444464466456666666666666666666666666666666666666666666666666666666666666666666666886666666666666566666666666666266666666666666666666666666666662266626666622668666666666666666226666666662666666666666626666622222622266662226662662662626666222226622662266266266566662226662222222222222222222222222222222222222822222222222222222225222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";
            //String map_test01 = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111331111111111111111111111111111111111111111111131111111111111111111111111111111111111111111111111111111111111111111111311111111111111111131111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111133111111131111111111111111133131111111111111111311111111113111113311111111111111311111111111111111111111111311111111111111111111111111111111111111111111111111111111111111111111111111111111113111111111111311111111111111111133311111111111111111111111111111311111111111111111111331111111113311111111111111111131111113111131111111111113111111111111111111331111111131313131111111111111111311111111111113111111111111111111111111111111111111111111111111311111111111111111111111111111131111111111111111111111111111111133111111131111111111111111111133311111111113111111111111111111133331111111311111111111111111111111111111111111111111111111111113333311111111111111333333111111111111111111111111111111111113111133333331111113333333333311113111313111311113113111311311113331133333331113331133333333331133333133313333333133113131311313333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333334443344334444334333333344333334333334433444433333333334433344334444344434444434443344344444333444444333333444443344444333344434444444444444444444433444444433444444443333444444444444443444444444444444444444444444444444444444444444444444444444445444444444444444445444444444444444444444444444444444444444444444444444444444444444446644444444444444444444444554444444446644444644466444466466446446666444464666444464466644666644446466644666444464466456666666666666666666666666666666666666666666666666666666666666666666666886666666666666566666666666666266666666666666666666666666666662266626666622668666666666666666226666666662666666666666626666622222622266662226662662662626666222226622662266266266566662226662222222222222222222222222222222222222822222222222222222225222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";
            //String map_first_successful_test= "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111131111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111311111111111111111111111111111111111111111111111111111111111111133111111111111111111111111111111111111111111111111111111111111133331111111111111111111111111111111111111111111111111111111111113333311111111111111111111111111111111111111111111111111111113333333333331111113333333333311113111313111311113113111311311133333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333334443344334444334333333344333334333334433444433333333334433344334444344434444434443344344444333444444333333444443344444333344434444444444444444444433444444433444444443333444444444444443444444444444444444444444444444444444444444444444444444444445444444444444444445444444444444444444444444444444444444444444444444444444444444444446644444444444444444444444554444444446644444644466444466466446446666444464666444464466644666644446466644666444464466456666666666666666666666666666666666666666666666666666666666666666666666886666666666666566666666666666266666666666666666666666666666662266626666622668666666666666666226666666662666666666666626666622222622266662226662662662626666222226622662266266266566662226662222222222222222222222222222222222222822222222222222222225222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";

            BoardManager.Instance.InitializeTestBoardFromString(map_test02);
            _mechanics.Add(new Wind());
            _mechanics.Add(new Gravity());
        }

        // FixedUpdate
        void FixedUpdate()
        {
            if (FixedUpdateTicksCounter == 0)
            {
                BEAT_NO++;
                BoardManager.Instance.Redraw();
                ApplyMechanics(BoardManager.Instance.GetCurrentBoard());
            }
            FixedUpdateTicksCounter = (FixedUpdateTicksCounter + 1) % FixedUpdateTicksPerBeat;
        }
        
    }
}