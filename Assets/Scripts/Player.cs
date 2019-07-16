using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Collider2D myCollider2D;
    Rigidbody2D myRigidbody;

    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    private object DestroygameObject;

    private void Run()
    {
        float controlDirection = Input.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlDirection * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVelocity;
    }
    private void Jump()
    {
        if (!myCollider2D.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }
        if (Input.GetButtonDown("Jump")) //If we're pressing Jump and we're on the Ground
        {
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            myRigidbody.velocity += jumpVelocityToAdd;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        myCollider2D = GetComponent<Collider2D>();

        myRigidbody = GetComponent<Rigidbody2D>();
    }

    
    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }
}