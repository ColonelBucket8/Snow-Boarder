using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float loadDelay = 0.5f;
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private AudioClip crashSFX;

    void Start()
    {
        crashEffect.Stop();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.CompareTag("Finish")) return;

        if (other.gameObject.CompareTag("Ground"))
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke(nameof(ResetLevel), loadDelay);
        }
    }

    private void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
