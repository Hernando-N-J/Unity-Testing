using System.Collections;
using UnityEngine;

public delegate void TextOutputHandler(string s);

public class GameSceneController : MonoBehaviour
{
    public float playerSpeed;
    public Vector3 screenBounds;
    public EnemyController enemyPrefab;

    private HUDController hUDController;
    private int totalPoints;


    private void Start()
    {
        hUDController = FindObjectOfType<HUDController>();
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
            EnemyController enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            enemy.EnemyEscaped += EnemyAtBottom;
            enemy.EnemyKilledAction += EnemyKilledMethod;
            yield return waitTime;
        }
    }

    private void EnemyKilledMethod(int pointValue)
    {
        totalPoints += pointValue;
        hUDController.scoreText.text = totalPoints.ToString();
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

    public void SendThisText(string output)
    {
        Debug.Log("This method comes from... " + this + ", and the output string parameter is: ... " + output);
    }

    private void EnemyAtBottom(EnemyController enemy)
    {
        Destroy(enemy.gameObject);
        Debug.Log("Enemy escaped");
    }
}
