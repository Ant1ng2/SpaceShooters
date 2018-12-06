using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerMover : MonoBehaviour {

    public float speed;

    public float fireRate;
    public GameObject bullet;
    public GameObject shotSpawn;
    private float nextFire;

    private Rigidbody rb;

    public Boundary boundary;
//    public float xMin, xMax, yMin, yMax;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontal, 0.0f, vertical) * speed;

        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.yMin, boundary.yMax) 
        );
    }

    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, shotSpawn.transform.position, shotSpawn.transform.rotation);
        }
    }
}
