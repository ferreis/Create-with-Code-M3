using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float countdown = 0.5f;
    const float spanwDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (countdown <= spanwDelay && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            countdown += spanwDelay;

        }
        countdown-=0.01f;
    }    
}
