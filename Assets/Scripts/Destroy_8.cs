using System.Collections;
using UnityEngine;

public class Destroy_8 : MonoBehaviour
{
    public AudioSource Audio;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        if (Audio == null) {
            Debug.Log("sound null.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Audio.Play();
            Debug.Log("Destroyed");
            Destroy(this.gameObject);
            
            ScoreScript.scoreValue += 8;
        }
    }
}
