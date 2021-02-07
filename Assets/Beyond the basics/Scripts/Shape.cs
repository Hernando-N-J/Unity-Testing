using UnityEngine;

public class Shape : MonoBehaviour
{
    public string Name;

    public void SetColor(Color newColor)
    {
        SpriteRenderer spriteRenderer =  GetComponent<SpriteRenderer>();
        spriteRenderer.color = newColor;
    }
}
