using UnityEngine;

public class ProjectileController : Shape, IKillable
{
    public Vector2 projectileDirection;
    public float projectileSpeed;

    protected override void Start()
    {
        base.Start();
        Debug.Log("Projectile spawned");

        Name = "Projectile";

        foreach (var n in ShowNames())
        {
            Debug.Log(n);
        }
    }

    private void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        transform.Translate(projectileDirection * projectileSpeed * Time.deltaTime, Space.World);

        float projectileTopPoint = transform.position.y + halfHeight;

        if (projectileTopPoint >= gameSceneController.screenBounds.y) // upper y is positive
            gameSceneController.KillObject(this);
    }

    public void Kill()
    {
        Destroy(gameObject);
    }

    public string GetName()
    {
        return Name;
    }

    private string[] ShowNames()
    {
        string a = "Ana";
        string b = "Bernardo";
        string c = "CArlos";

        string[] namesArray = { a, b, c };
        return namesArray;
    }
}
