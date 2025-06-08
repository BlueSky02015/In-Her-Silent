using UnityEngine;

public class EnemyEffect : MonoBehaviour
{
    public float shakeDuration = 1f;
    public float targetFocusDuration = 2f; // How long camera stays on target

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Make camera target this enemy temporarily
            CameraController.Instance.SetTarget(transform, targetFocusDuration);
            
            // Shake the camera
            CameraController.Instance.StartCoroutine(CameraController.Instance.Shake(shakeDuration)
            );
            
            // // Disable trigger to prevent retriggering
            // GetComponent<Collider>().enabled = false;
        }
    }
}