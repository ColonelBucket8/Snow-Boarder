using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ResetLevel();
        }
    }

    private static void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
