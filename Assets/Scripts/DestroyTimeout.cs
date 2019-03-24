using UnityEngine;
using System.Collections;
public class DestroyTimeout : MonoBehaviour
{
    public float timer = 10.0f;
    void Start()
    {
        Destroy(gameObject, timer);
    }
}