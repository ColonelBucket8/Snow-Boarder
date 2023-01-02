using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.CompareTag("Finish")) return;

        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("You hit your head!");

        }
    }
}
