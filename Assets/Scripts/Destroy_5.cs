using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_5 : MonoBehaviour
{
    public AudioSource tickSource;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball" ) {
            tickSource.Play();
            Debug.Log("Destroyed");
            Destroy(this.gameObject);
            
            ScoreScript.scoreValue += 5;
        }
    }
}
