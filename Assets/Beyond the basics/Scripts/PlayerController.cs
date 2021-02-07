using UnityEngine;

public class PlayerController : Shape
{
    public ProjectileController projectilePrefab;

    protected override void Start()
    {
        base.Start();
        SetColor(Color.cyan);
    }

    private void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space))
            FireProjectile();
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if(Mathf.Abs(moveHorizontal) > Mathf.Epsilon)
        {
            moveHorizontal = moveHorizontal * Time.deltaTime  * gameSceneController.playerSpeed;
            moveHorizontal += transform.position.x;

            float maxRightBound = gameSceneController.screenBounds.x - halfWidth;
            float minLeftBound = -maxRightBound;
            float limit = Mathf.Clamp(moveHorizontal, minLeftBound, maxRightBound);

            transform.position = new Vector2(limit, transform.position.y);
        }
    }

    private void FireProjectile()
    {
        Vector2 spawnPosition = transform.position;

        ProjectileController projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        projectile.projectileSpeed = 2;
        projectile.projectileDirection = Vector2.up;
    }
}
