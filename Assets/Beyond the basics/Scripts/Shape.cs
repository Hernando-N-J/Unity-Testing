using UnityEngine;

public class Shape : MonoBehaviour
{
    public string Name;
    protected GameSceneController gameSceneController;
    protected SpriteRenderer spriteRenderer; 
    protected float halfWidth;
    protected float halfHeight;

    protected virtual void Start()
    {
        gameSceneController = FindObjectOfType<GameSceneController>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        halfWidth = spriteRenderer.bounds.extents.x;
        halfHeight = spriteRenderer.bounds.extents.y;
    }

    public void SetColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }

    public void SetColor(float red, float green, float blue)
    {
        Color newObjectColor = new Color(red, green, blue);
        spriteRenderer.color = newObjectColor;
    }
}
