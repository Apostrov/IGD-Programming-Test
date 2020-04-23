using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rgdbody2D;

    private void Start()
    {
        rgdbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate ()
    {
        if (rgdbody2D.velocity.magnitude <= 0.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
        else if (!other.CompareTag("ShootEnemy"))
        {
            Destroy(gameObject);
        }
    }
}
