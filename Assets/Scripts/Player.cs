using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    

    Collider2D myCollider2D;
    Rigidbody2D myRigidbody;
    bool isOnLadder;
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;

    private object DestroygameObject;

    [SerializeField] GameObject objecttoDestroy;
    [SerializeField] GameObject objecttoDestroy2;
    [SerializeField] GameObject objecttoDestroy3;
    [SerializeField] GameObject objecttoDestroy4;
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.collider.name == "Chest")
            {
                Destroy(objecttoDestroy);
                Destroy(objecttoDestroy2);
                Destroy(objecttoDestroy3);
                Destroy(objecttoDestroy4);
            }

    }

    // Permeet
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


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(!(Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.RightArrow))))
            isOnLadder = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isOnLadder = false;
        myRigidbody.gravityScale = 1;
        
    }


    // Start is called before the first frame update
    void Start()
    {
        myCollider2D = GetComponent<Collider2D>();

        myRigidbody = GetComponent<Rigidbody2D>();
    }

    

    void Update()
    {
        if (isOnLadder == true)
        {
            myRigidbody.gravityScale = 0;

           if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 0.1f);
                //GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 2f);
            }
           if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.RightArrow)))
            {
                isOnLadder = false;
            }
            
             
        }
        if (!isOnLadder)
        {
            Run();
            Jump();
            myRigidbody.gravityScale = 1;
        }
    }

   
}