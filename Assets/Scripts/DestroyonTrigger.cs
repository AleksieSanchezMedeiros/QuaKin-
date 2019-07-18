//Permeet

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonTrigger : MonoBehaviour
{

    [SerializeField] GameObject objecttoDestroy;
    [SerializeField] GameObject objecttoDestroy2;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(objecttoDestroy);


        Destroy(objecttoDestroy2);

        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
