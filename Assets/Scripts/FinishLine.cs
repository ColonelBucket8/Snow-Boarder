using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem particleSystem;


    void Start()
    {
        particleSystem.Stop();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke(nameof(ReloadScene), loadDelay);
            particleSystem.Play();
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
