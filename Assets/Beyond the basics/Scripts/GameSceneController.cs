using System.Collections;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public float playerSpeed;
    public Vector3 screenBounds;
    public EnemyController enemyPrefab;

    private void Start()
    {
        playerSpeed = 10;
        screenBounds = GetScreenBounds();
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds waitTime = new WaitForSeconds(2);

        while (true)
        {
            float UpperPosition = Random.Range(screenBounds.x, -screenBounds.x);
            Vector2 spawnPosition = new Vector2(UpperPosition, screenBounds.y);
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            yield return waitTime;
        }
    }

    // Calculates and returns the bounds (borders) of the screen in WorldSpace
    public Vector3 GetScreenBounds()
    {
        Camera mainCamera = Camera.main;

        Vector3 screenVector = new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z);

        return mainCamera.ScreenToWorldPoint(screenVector);
    }

    public void KillObject(IKillable killable)
    {
        Debug.LogWarningFormat("{0} killed by GameSceneController", killable.GetName());
        killable.Kill();
    }
}
