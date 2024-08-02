using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private float deadZone = -20f;
    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

}
