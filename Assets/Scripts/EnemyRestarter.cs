using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyRestarter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
