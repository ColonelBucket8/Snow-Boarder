using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float loadDelay = 0.5f;
    [SerializeField] private ParticleSystem particleSystem;

    void Start()
    {
        particleSystem.Stop();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.CompareTag("Finish")) return;

        if (other.gameObject.CompareTag("Ground"))
        {
            particleSystem.Play();
            Invoke(nameof(ResetLevel), loadDelay);
        }
    }

    private void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
