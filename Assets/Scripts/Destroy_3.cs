using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_3 : MonoBehaviour
{
    public AudioSource tickSource;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Destroyed");
            tickSource.Play();
            Destroy(this.gameObject);
            ScoreScript.scoreValue += 3;
        }
    }
}
