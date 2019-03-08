using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_8 : MonoBehaviour
{
    public AudioSource tickSource;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {   tickSource = GetComponent<AudioSource>();
            Debug.Log("Destroyed");
            Destroy(this.gameObject);
            tickSource.Play();
            ScoreScript.scoreValue += 8;
        }
    }
}
