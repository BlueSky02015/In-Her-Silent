using UnityEngine;

public class InteractDoor : Interactable
{
    // [SerializeField] private Animator doorAnimator;
    // [SerializeField] private string openAnimationTrigger = "Open";
    // [SerializeField] private string closeAnimationTrigger = "Close";

    protected override void Interact()
    {

        // if (doorAnimator != null)
        // {
        //     // Toggle the door state based on the current animation state
        //     if (doorAnimator.GetCurrentAnimatorStateInfo(0).IsName("Closed"))
        //     {
        //         doorAnimator.SetTrigger(openAnimationTrigger);
        //     }
        //     else
        //     {
        //         doorAnimator.SetTrigger(closeAnimationTrigger);
        //     }
        // }
        // else
        // {
        //     Debug.LogWarning("Door animator is not assigned.");
        // }
    }
    
}