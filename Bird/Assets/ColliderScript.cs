using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public GameLogicScript gameLogicScript;

    // Start is called before the first frame update
    void Start()
    {
        GameObject logicObject = GameObject.FindGameObjectWithTag("logic");
        if (logicObject != null)
        {
            gameLogicScript = logicObject.GetComponent<GameLogicScript>();
            if (gameLogicScript == null)
            {
                Debug.LogError("GameLogicScript component not found on the GameObject with tag 'logic'.");
            }
        }
        else
        {
            Debug.LogError("GameObject with tag 'logic' not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameLogicScript != null & collision.gameObject.layer == 3)
        {
            gameLogicScript.addScore();
        }
        else
        {
            Debug.LogError("gameLogicScript is not assigned.");
        }
    }
}