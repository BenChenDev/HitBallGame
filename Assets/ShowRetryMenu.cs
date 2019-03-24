using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRetryMenu : MonoBehaviour
{
    public GameObject retryMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue == 50) {
            retryMenu.SetActive(true);
        }
    }
}
