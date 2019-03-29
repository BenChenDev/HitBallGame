using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRetryMenu : MonoBehaviour
{
    public GameObject retryMenu;
    AudioSource winSound;
    // Start is called before the first frame update
    void Start()
    {
        winSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue == 50) {
            winSound.Play();
            Debug.Log("Won the game!");
            retryMenu.SetActive(true);
            ScoreScript.scoreValue = 0;
            if (ScoreScript.bgm.isPlaying) {
                ScoreScript.bgm.Stop();
            }
        }
    }
}
