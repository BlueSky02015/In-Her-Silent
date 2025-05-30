using UnityEngine;

public class CollectableItem : Interactable
{
    public GameObject particle;

    protected override void Interact()
    {
        Debug.Log("Collectable item interacted with: " + gameObject.name);
        
        // Play particle effect
        if (particle != null)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
        }

        // Destroy the collectable item
        Destroy(gameObject);

        // Optionally, you can add logic to update the player's inventory or score here
    }

}