using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] private string prompt = "Press [E] to interact";

    public abstract void Interact();

    public void ShowPrompt()
    {
        // TODO Later with UI
        Debug.Log(prompt);
    }

    public void HidePrompt()
    {
        Debug.Log("Not in range");
        // Hide UI 
    }

}
