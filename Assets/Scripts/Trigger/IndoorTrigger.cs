using UnityEngine;

public class IndoorTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMove playerMove = other.GetComponent<PlayerMove>();
            if (playerMove != null)
            {
                // Play indoor footstep sound
                playerMove.SetIndoor(true);
            }
        }
    }
}