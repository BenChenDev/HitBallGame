using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void quitGame() {
        Application.Quit();
        Debug.Log("Quit game triggered!");
    }
}
