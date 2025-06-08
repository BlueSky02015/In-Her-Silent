using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera timelineCamera;
    
    public void SwitchToMainCamera()
    {
        if (mainCamera != null) mainCamera.gameObject.SetActive(true);
        if (timelineCamera != null) timelineCamera.gameObject.SetActive(false);
    }
    
    public void SwitchToTimelineCamera()
    {
        if (mainCamera != null) mainCamera.gameObject.SetActive(false);
        if (timelineCamera != null) timelineCamera.gameObject.SetActive(true);
    }
}