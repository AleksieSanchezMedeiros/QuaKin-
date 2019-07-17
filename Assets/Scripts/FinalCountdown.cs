using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCountdown : MonoBehaviour
{

    [SerializeField] GameObject objecttoDestroy;
    [SerializeField] GameObject objecttoDestroy2;
    [SerializeField] GameObject objecttoDestroy3;
    [SerializeField] GameObject objecttoDestroy4;
    [SerializeField] GameObject objecttoDestroy5;
    [SerializeField] GameObject objecttoDestroy6;
    [SerializeField] GameObject objecttoDestroy7;
    [SerializeField] GameObject objecttoDestroy8;
    [SerializeField] GameObject objecttoDestroy9;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(objecttoDestroy);
        Destroy(objecttoDestroy2);
        Destroy(objecttoDestroy3);
        Destroy(objecttoDestroy4);
        Destroy(objecttoDestroy5);
        Destroy(objecttoDestroy6);
        Destroy(objecttoDestroy7);
        Destroy(objecttoDestroy8);
        Destroy(objecttoDestroy9);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}