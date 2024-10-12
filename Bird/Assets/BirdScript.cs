using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "first unit bird";
        


    }

    // Update is called once per frame
    void Update()
    {
        birdRigidbody.velocity = Vector2.up * 10;
        
    }
}
