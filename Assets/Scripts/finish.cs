using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{

    private AudioSource finishSound;
    private bool levelCompleated = false;

   private void Start()
    {

        finishSound = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        
        if (collision.gameObject.name == "Player" && !levelCompleated)
        {
            finishSound.Play();
            levelCompleated = true;
            Invoke("ComplateLevel1",  2f);
        
        }
    }

    private void ComplateLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
