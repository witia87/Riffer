using UnityEngine;

namespace Assets.Scripts.Gui
{
    public class GuiGuageController : GuiArtifactController
    {
        private Animator _animator;

        private GameObject _backgroundGo;
        private SpriteRenderer _backgroundSpriteRenderer;
        private SpriteRenderer _spriteRenderer;
        public Sprite BackgroundSprite;
        public bool Broken = false;
        [Range(0, 1)] public float fill;
        public RuntimeAnimatorController GaugeController;

        ///// Functions


        /*
        public float GetFill() { return fill; }
        public void SetFill(float value) { fill = value; }
        */


        ///// MonoBehaviour
        // Start
        private void Start()
        {
            _backgroundGo = new GameObject("background");
            _backgroundGo.transform.SetParent(gameObject.transform);
            _backgroundGo.transform.localPosition = Vector3.zero;
            _backgroundSpriteRenderer = _backgroundGo.gameObject.AddComponent<SpriteRenderer>();
            _backgroundSpriteRenderer.sortingLayerName = "gui";
            _backgroundSpriteRenderer.sortingOrder = 0;
            _backgroundSpriteRenderer.sprite = BackgroundSprite;

            _spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
            _spriteRenderer.sortingLayerName = "gui";
            _spriteRenderer.sortingOrder = 1;

            _animator = gameObject.AddComponent<Animator>();
            _animator.runtimeAnimatorController = GaugeController;

            SwitchOn();
        }

        // Update
        private void Update()
        {
            _animator.SetFloat("fill", Mathf.Clamp(fill, 0f, 0.999f));
            _animator.SetBool("broken", Broken);
        }
    }
}