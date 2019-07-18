using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start: MonoBehaviour
{
    public void LoadLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
