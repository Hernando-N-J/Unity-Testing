using UnityEngine;

public class PlayerTest : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            UtilityHelper.ChangeColor(gameObject, Color.blue, false);

        if (Input.GetKeyDown(KeyCode.E))
            UtilityHelper.ChangeColor(gameObject, Color.red, true);
    }
}