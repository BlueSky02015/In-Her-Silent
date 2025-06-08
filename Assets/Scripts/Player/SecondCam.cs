using UnityEngine;

public class SecondCam : MonoBehaviour {
    public Transform player;
    public float speed;
    public Vector3 offset;
    public float followdistand;
    public Quaternion rotation;

    void Update()
    {
        Vector3 pos = Vector3.Lerp(transform.position, player.position + offset + -transform.forward * followdistand, speed * Time.deltaTime);
        transform.position =  pos;
        transform.rotation = rotation;
    }
}