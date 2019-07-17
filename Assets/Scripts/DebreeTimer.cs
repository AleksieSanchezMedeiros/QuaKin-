using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebreeTimer : MonoBehaviour
{

    [SerializeField] GameObject debreePrefab;
    // setting varibles
    float timer = 5f;
    float randomX;
    float randomY;


    // Start is called before the first frame update
    void Start()
    {
        randomX = Random.Range(-6f, 2f);
        randomY = Random.Range(32f, 1f);

    }
    //counts down timer spawns object them resets timer
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 5f;
            Vector2 newPowerPos = new Vector2(Random.Range(-6f, 2f),Random.Range(32f, 1f));


            GameObject fallingDebree = Instantiate(debreePrefab, newPowerPos, Quaternion.identity);

        }

    }}
