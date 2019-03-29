using System.Collections;
using UnityEngine;

public class Destroy_8 : MonoBehaviour
{
    AudioSource tickSource;
    private Vector3 position;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    public void distory() {
        Debug.Log("Destroyed");


        ScoreScript.scoreValue += 5;
        tickSource.Play();
        Debug.Log("sound effect!");
        if (ScoreScript.scoreValue == 50)
        {
            //do nothing
        }
        else
        {
            position = new Vector3(Random.Range(-14f, 14f), Random.Range(0.7f, 6f), Random.Range(-14f, 14f));
            Instantiate(Resources.Load("8Score"), position, Quaternion.identity);
        }
        
        Destroy(this.gameObject, 0.3f);
    }
}
