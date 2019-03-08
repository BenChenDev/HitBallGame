using UnityEngine;
using System.Collections;

//Add this Script Directly to The Death Zone
public class BallHit : MonoBehaviour
{
    public AudioSource tickSource;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        
    }

    void OnCollisionEnter()
    {
        tickSource.Play();
    }
}
