using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public Transform player;
    public float speed = 10f;
    public Rigidbody2D projectile;
    public float tMin, tMax;

    private float waitTime = 1.0f;

    private void Shoot()
    {
        Rigidbody2D projectileClone = (Rigidbody2D) Instantiate(projectile, transform.position, transform.rotation);
        projectileClone.gameObject.SetActive(true);
        projectileClone.velocity = (player.position - projectileClone.transform.position).normalized * speed;
    }

    private void Update()
    {
        if (waitTime <= 0f)
        {
            waitTime = Random.Range(tMin, tMax);
            Shoot();
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}
