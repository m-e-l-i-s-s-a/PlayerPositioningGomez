using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool dogSpawnReady = false;

    // Update is called once per frame
    void Update()
    {

        if (!dogSpawnReady)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogSpawnReady = true;
            }
            Limit();
        }
    }

    void Limit()
    {
        dogSpawnReady = false;
    }
}
