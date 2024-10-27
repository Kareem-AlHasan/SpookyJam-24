using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : Interactable
{
    public string hint = "Hint fo player";
    public GameObject itemsInPanel;


    public override void Interact()
    {
        // TODO Add to player inventory 
        Debug.Log(hint);
        itemsInPanel.SetActive(true);
        Destroy(gameObject);
    }
}
