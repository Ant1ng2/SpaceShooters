using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

    public float lifeTime;

    private float currentTime;

    void Start()
    {
        currentTime = Time.time;
    }

    void FixedUpdate()
    {
        if (Time.time - currentTime == lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
