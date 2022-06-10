using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    [Header("Movement")]
    public float moveAccel;
    public float maxSpeed;
    private Rigidbody2D rb;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        Vector2 velocityVector = rb.velocity;
        velocityVector.x = Mathf.Clamp(velocityVector.x + moveAccel * Time.deltaTime,
        0.0f, maxSpeed);
        rb.velocity = velocityVector;
    }

    void Update()
    {
        
    }
}
