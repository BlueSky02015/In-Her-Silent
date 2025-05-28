using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // This class serves as a base class for all interactable objects in the game.
    public string promptMessage;

    public void BaseInteract()
    {
        // This method is called when the interactable object is interacted with.
        // It can be overridden by derived classes to provide specific interaction behavior.
        Interact();
    }

    protected virtual void Interact()
    {
        // This method should be overridden by derived classes to define specific interaction behavior.
        // It can be left empty if the derived class does not require any interaction logic.
    }
}
