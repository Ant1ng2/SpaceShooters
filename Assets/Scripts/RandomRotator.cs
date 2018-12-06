using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    private Vector3 Fill;

    void Start()
    {
        Fill = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
    }

    void FixedUpdate()
    {
        transform.Rotate(Fill);
    }
}
