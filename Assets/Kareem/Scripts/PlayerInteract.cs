using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float interactRange = 2f;
    public Lantern lantern;
    public GameObject inventory = null;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && inventory != null) {
            if (inventory.activeInHierarchy) {
                inventory.SetActive(false);
            }
            else {
                inventory.SetActive(true);
            }
        }

            if (Input.GetKeyDown(KeyCode.Q) && lantern.inHand)
        {
            lantern.Drop();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D[] cols = Physics2D.OverlapCircleAll(transform.position, interactRange);
            foreach (Collider2D col in cols)
            {
                if (col.TryGetComponent(out Interactable interactable))
                {
                    interactable.Interact();
                }
            }
        }
    }

    public Interactable GetInteractable()
    {
        Collider2D[] cols = Physics2D.OverlapCircleAll(transform.position, interactRange);
        foreach (Collider2D col in cols)
        {
            if (col.TryGetComponent(out Interactable interactable))
            {
                return interactable;
            }
        }

        return null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, interactRange);
    }
}
