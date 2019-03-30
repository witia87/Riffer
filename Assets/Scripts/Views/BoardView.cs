using System;
using Assets.Scripts;
using UnityEngine;

public class BoardView : MonoBehaviour
{
    private static float FIELD_WIDTH = 0.25f;
    private static float FIELD_HEIGHT = 0.25f;
    public Sprite sprite;

    public static readonly String FIELD_NAME_PATTERN = "Field[{0},{1}]";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize()
    {
        var fields = transform.GetComponentsInChildren<FieldView>();
        foreach (FieldView field in fields)
        {
            GameObject.DestroyImmediate(field.gameObject);
        }
        
        for(var row = 0; row < Board.HEIGHT; row++)
        {
            for (var column = 0; column < Board.WIDTH; column++)
            {
                GameObject fieldGameObject = new GameObject(String.Format(FIELD_NAME_PATTERN, row, column));
                SpriteRenderer renderer = fieldGameObject.AddComponent<SpriteRenderer>();
                renderer.sprite = sprite;
                var fieldView = fieldGameObject.AddComponent<FieldView>();
                fieldView.SetPosition(row, column);
                fieldGameObject.transform.parent = transform;
                fieldGameObject.transform.localPosition = new Vector2((column + 0.5f) * FIELD_WIDTH, (row + 0.5f) * FIELD_HEIGHT);
            }
        }
    }
}
