using UnityEngine;

public class UtilityHelper : MonoBehaviour
{
    public static void ChangeColor(GameObject obj, Color color, bool setRandomColor)
    {
        if (setRandomColor) color = new Color(Random.value, Random.value, Random.value);

        obj.GetComponent<Renderer>().material.color = color;
    }
}
