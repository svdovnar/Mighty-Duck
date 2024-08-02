using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float jumpForce = 10f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            rigidbody.velocity = Vector2.up * jumpForce;

        }
    }
}
