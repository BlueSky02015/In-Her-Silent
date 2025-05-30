using UnityEngine;

public class OutdoorTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMove playerMove = other.GetComponent<PlayerMove>();
            if (playerMove != null)
            {
                // Play outdoor footstep sound
                playerMove.SetIndoor(false);
            }
        }
    }
}