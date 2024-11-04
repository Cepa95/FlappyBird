using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidbody;
    public float goUpForce = 5;
    public GameLogicScript logic;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "first unit bird";
        if (birdRigidbody == null)
        {
            birdRigidbody = GetComponent<Rigidbody2D>();
        }

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<GameLogicScript>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            birdRigidbody.velocity = Vector2.up * goUpForce;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameFinished();
        isAlive = false;

    }
}