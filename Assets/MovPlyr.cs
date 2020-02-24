using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlyr : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector3 newPosition = new Vector3(movement.x, 0.0f, movement.y);
        transform.LookAt(newPosition + transform.position);
        transform.Translate(newPosition * moveSpeed * Time.deltaTime, Space.World);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
