using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Instantiate(bullet,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rgd = ball.GetComponent<Rigidbody>();
            rgd.velocity = transform.forward * speed;

        }
    }
}
