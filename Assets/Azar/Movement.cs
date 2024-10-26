using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    // Update is called once per frame
    void FixedUpdate() {
        Vector3 moveDir = MoveVec();
        transform.position += moveDir * Time.deltaTime * moveSpeed;
    }

    private Vector3 MoveVec() {
        Vector2 moveDir = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.A)) {
            moveDir.x -= 1;
        }
        if (Input.GetKey(KeyCode.D)) {
            moveDir.x += 1;
        }
        if (Input.GetKey(KeyCode.S)) {
            moveDir.y -= 1;
        }
        if (Input.GetKey(KeyCode.W)) {
            moveDir.y += 1;
        }

        moveDir = moveDir.normalized;
        return (Vector3)moveDir;
    }
}
