using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireDelta = 1.0f;
    private float nextFire = 0.5f;
    private float myTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireDelta;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            nextFire = nextFire - myTime;
            myTime = 0.0f;
        }
    }
}
