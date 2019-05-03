using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Assets.Scripts.Gui
{

    public class GuiGuageController : GuiArtefactController
    {

        ///// Variables

        [Range (0, 1)] public float fill;
        public bool broken = false;
        public RuntimeAnimatorController guageController;
        public Sprite backgroundSprite;

        private GameObject _backgroundGO;
        private SpriteRenderer _spriteRenderer;
        private SpriteRenderer _backgroundSpriteRenderer;
        private Animator _animator;

        ///// Functions
        

        /*
        public float GetFill() { return fill; }
        public void SetFill(float value) { fill = value; }
        */


        ///// MonoBehaviour
        // Start
        void Start() {
            _backgroundGO = new GameObject("background");
            _backgroundGO.transform.SetParent(this.gameObject.transform);
            _backgroundGO.transform.localPosition = Vector3.zero;
            _backgroundSpriteRenderer = _backgroundGO.gameObject.AddComponent<SpriteRenderer>();
            _backgroundSpriteRenderer.sortingLayerName = "gui";
            _backgroundSpriteRenderer.sortingOrder = 0;
            _backgroundSpriteRenderer.sprite = backgroundSprite;

            _spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
            _spriteRenderer.sortingLayerName = "gui";
            _spriteRenderer.sortingOrder = 1;

            _animator = this.gameObject.AddComponent<Animator>();
            _animator.runtimeAnimatorController = guageController;

            SwitchOn();
        }

        // Update
        void Update() {
            _animator.SetFloat("fill", Mathf.Clamp(fill,0f,0.999f));
            _animator.SetBool("broken", broken);
        }
    }
}