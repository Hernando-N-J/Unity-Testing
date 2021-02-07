using UnityEngine;

public class EnemyController : Shape, IKillable
{


    protected override void Start()
    {
        base.Start();
        Debug.Log("Enemy spawned... message from EnemyController");

        Name = "Enemy";
    }

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        transform.Translate(Vector2.down * Time.deltaTime, Space.World);

        float enemyBottomPoint = transform.position.y - halfHeight;

        if (enemyBottomPoint <= -gameSceneController.screenBounds.y) // lower y, negative
            //Kill();
        gameSceneController.KillObject(this);
    }

    public void Kill()
    {
        Destroy(gameObject);
        Debug.LogWarning("killed by " + this);
    }

    public string GetName()
    {
        return Name;
    }
}
