using UnityEngine;

public class InteractableKey : Interactable 
{
    public LockedDoor doorToUnlock; 
    
    protected override void Interact()
    {
        if (doorToUnlock != null)
        {
            doorToUnlock.TryUnlock(true);
            Destroy(gameObject); 
        }
    }
}