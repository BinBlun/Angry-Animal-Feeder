using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeCooldown = 2.0f;
    public float timeSincePressSpace = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timeSincePressSpace += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSincePressSpace > timeCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSincePressSpace = 0.0f;
        }
    }
}
