using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera playerCamera;
    private float xRotation = 0f;

    public float XmouseSensitivity = 30f;
    public float YmouseSensitivity = 30f;



    public void Look(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        xRotation -= mouseY * YmouseSensitivity * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);
        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * XmouseSensitivity);
    }
}