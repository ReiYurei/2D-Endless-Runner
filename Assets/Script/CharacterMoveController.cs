using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
   
    [Header("Movement")]
    public float moveAccel;
    public float maxSpeed;
    private Rigidbody2D rig;
    private Animator anim;
    
    [Header("Jumping")]
    public float jumpAccel;
    private bool isJumping;
    private bool isOnGround;
    private CharacterSoundController sound;

    [Header("Ground Raycast")]
    public float groundRaycastDistance;
    public LayerMask groundLayerMask;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sound = GetComponent<CharacterSoundController>();
    }
    void FixedUpdate()
    {
        Vector2 velocityVector = rig.velocity;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down,
        groundRaycastDistance, groundLayerMask);
        if (hit)
        {
            if (!isOnGround && rig.velocity.y <= 0)
            {
                isOnGround = true;
            }
        }
        else
        {
            isOnGround = false;
        }
        if (isJumping)
        {
            velocityVector.y += jumpAccel;
            isJumping = false;
        }


        velocityVector.x = Mathf.Clamp(velocityVector.x + moveAccel * Time.deltaTime,
        0.0f, maxSpeed);
        rig.velocity = velocityVector;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isOnGround)
            {
                isJumping = true;
                sound.PlayJump();
            }
        }
        anim.SetBool("isOnGround", isOnGround);

    }
    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position, transform.position + (Vector3.down *
        groundRaycastDistance), Color.white);
    }
}
