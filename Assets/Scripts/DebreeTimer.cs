using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebreeTimer : MonoBehaviour
{

    [SerializeField] GameObject debreePrefab;
    // setting varibles
    float timer = 2f;
    float randomX;
    float randomY;


    // Start is called before the first frame update
    void Start()
    {
        randomX = Random.Range(-10f, 2f);
        randomY = Random.Range(32f, 5f);

    }
    //counts down timer spawns object them resets timer
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 2;
            Vector2 newPowerPos = new Vector2(Random.Range(-10f, 2f),Random.Range(32f, 5f));


            GameObject fallingDebree = Instantiate(debreePrefab, newPowerPos, Quaternion.identity);

        }

    }}
