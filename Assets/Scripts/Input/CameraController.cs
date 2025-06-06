using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;
    
    private Transform defaultTarget; // Player
    private Transform currentTarget;
    private Vector3 defaultOffset;
    
    [Header("Targeting Offset")]
    public Vector3 targetOffset = new Vector3(-1f, 0f, 0f); 
    
    void Awake()
    {
        Instance = this;
        defaultTarget = transform.parent; 
        defaultOffset = transform.localPosition;
    }

    void LateUpdate()
    {
        Transform target = currentTarget ?? defaultTarget;
        
        if (target != null)
        {
            Vector3 targetPos = target.position + defaultOffset;
            if (currentTarget != null)
                targetPos += targetOffset;
            
            targetPos.y = transform.position.y; 
            
            // Smooth follow
            transform.position = Vector3.Lerp(
                transform.position,
                targetPos,
                Time.deltaTime * 5f
            );
        }
    }

    public void SetTarget(Transform target, float duration = 0f)
    {
        currentTarget = target;
        
        if (duration > 0)
            StartCoroutine(ResetAfterDelay(duration));
    }

    public void ResetTarget()
    {
        currentTarget = null;
    }

    IEnumerator ResetAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetTarget();
    }

    public IEnumerator Shake(float duration, float magnitude = 0.5f)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = originalPos + new Vector3(x, y, 0);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = originalPos;
    }
}