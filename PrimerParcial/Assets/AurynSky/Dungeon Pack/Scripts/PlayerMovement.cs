using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Evitar que el jugador se caiga o rote
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal"); // A (-1) y D (1)
        float moveZ = Input.GetAxis("Vertical"); // W (1) y S (-1)

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;

        rb.MovePosition(transform.position + moveDirection * speed * Time.deltaTime);
    }
}
