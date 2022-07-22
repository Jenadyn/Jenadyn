using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}