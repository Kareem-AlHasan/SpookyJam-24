using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : Interactable
{
    public PlayerInteract player;
    public bool inHand = false;

    public override void Interact()
    {
        // when interact - make child of player light pos
        transform.parent = player.transform.GetChild(0).transform;
        transform.position = player.transform.GetChild(0).transform.position;
        inHand = true;
        Debug.Log("Pick Up");
    }

    public void Drop()
    {
        inHand = false;
        transform.parent = null;
        transform.position = new Vector2(transform.position.x, transform.position.y - 0.4f);
    }
}
