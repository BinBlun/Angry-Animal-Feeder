using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float borderBound = 40.0f;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes pass the player view in the game, remove that object
        if (transform.position.z > topBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x > borderBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject) ;
        }
        else if (transform.position.x < -borderBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
