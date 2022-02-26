using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Object we will attach to script for spawning object
    [Header("Spikes Object for controlling the game")]
    public GameObject spikes;
    //Height position of the spikes
    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        //start function repeating every 4 seconds
        InvokeRepeating("InstantiateObjects", 1f, 4f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5, Random.Range(-height, height), 0);

    }

    //instantiateObjects function
    void InstantiateObjects()
    {
        //Spawn object by position and rotation
        Instantiate(spikes, transform.position, transform.rotation);
    }

}
