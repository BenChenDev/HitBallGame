using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private Vector3 position;
    public GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        Debug.Log("Start Game!!");
        mainMenu.SetActive(false);
        if (!ScoreScript.bgm.isPlaying) {
            ScoreScript.bgm.Play();
        }
        if (ScoreScript.scoreValue != 0) {
            ScoreScript.scoreValue = 0;
            
        }
            position = new Vector3(Random.Range(-14f, 14f), Random.Range(0.7f, 6f), Random.Range(-14f, 14f));
            Instantiate(Resources.Load("8Score"), position, Quaternion.identity);
    }
}
