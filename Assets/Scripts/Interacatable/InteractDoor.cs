using UnityEngine;

public class InteractDoor : Interactable
{
    [SerializeField] private GameObject door => this.gameObject;
    [SerializeField] private bool isOpen;

    protected override void Interact()
    {
        Animator animator = door.GetComponent<Animator>();
        isOpen = !isOpen;
        // Only try to set the parameter if we found an Animator
        if (animator != null)
        {
            animator.SetBool("IsOpen", isOpen);
        }
        // if the animation is playing dont make the player be able to interact with the door fow a few seconds
    }

}