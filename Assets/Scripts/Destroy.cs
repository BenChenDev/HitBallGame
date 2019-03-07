using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject hitBy;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball" ) {
            Debug.Log("Destroyed");
            Destroy(this.gameObject);
        }
    }
}
