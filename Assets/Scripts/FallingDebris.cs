using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDebris : MonoBehaviour
{
    [SerializeField] GameObject objecttoDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Player")
        {
            Destroy(objecttoDestroy);
            Destroy(gameObject);
        }
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
