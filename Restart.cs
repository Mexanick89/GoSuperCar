using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private AudioSource fin;
    [SerializeField] private AudioSource star;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Restart")
        {
            SceneManager.LoadScene(0);
        }
        if (collision.tag == "Start")
        {
            star.Play();
        }
        if (collision.tag == "Fin")
        {
            fin.Play();
        }
    }
}
