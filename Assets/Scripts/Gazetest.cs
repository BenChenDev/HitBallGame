using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Gazetest : MonoBehaviour
{

    public float gazeTime = 2f;
    private float timer;
    private bool gazeAt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gazeAt) {
            timer += Time.deltaTime;
            Debug.Log("timer: " + timer + ", gazetime: " + gazeTime);
            if (timer >= gazeTime) {
                boxMoveUp();
                gazeAt = false;
                timer = 0;
            }
        }
        
    }

    private void boxMoveUp() {
        transform.position += new Vector3(0f, 1f, 0f);
    }

    public void lookat() {
        gazeAt = true;
        
    }
}
