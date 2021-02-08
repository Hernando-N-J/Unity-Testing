using System;
using UnityEngine;

public delegate void EnemyEscapeHandler(EnemyController enemy);

public class EnemyController : Shape, IKillable
{
    public event EnemyEscapeHandler EnemyEscaped;
    public event Action<int> EnemyKilledAction;

    protected override void Start()
    {
        base.Start();
        Name = "Enemy";
    }

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        // t is any method that matches the TextOutputHandler delegate signature
        transform.Translate(Vector2.down * Time.deltaTime, Space.World);

        float enemyBottomPoint = transform.position.y - halfHeight;

        if (enemyBottomPoint <= -gameSceneController.screenBounds.y)
            if(EnemyEscaped != null)
                EnemyEscaped(this);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(EnemyKilledAction != null)
            EnemyKilledAction(10);

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
