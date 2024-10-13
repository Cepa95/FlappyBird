using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidbody;
    public float goUpForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "first unit bird";
        if (birdRigidbody == null)
        {
            birdRigidbody = GetComponent<Rigidbody2D>();
        }



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidbody.velocity = Vector2.up * goUpForce;

        }

    }
}