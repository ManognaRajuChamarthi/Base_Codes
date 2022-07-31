using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [HeaderAttribute("Instantiations")]
    public GameObject objectToBeSpawned;
    public Vector3 spawnPosition;
    public Quaternion spawnRotation;

    [HeaderAttribute("Call Function Settings")]
    public float startTime;
    public float timeDelay;

    //converting strings to variables
    private string Spawnfunction = "SpawnFunction";

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(Spawnfunction, startTime, timeDelay);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnFunction()
    {
        Instantiate(objectToBeSpawned, spawnPosition, spawnRotation);
    }

    // please note that this script doesn't provide a means to the destroy the instanciated objects.
    // use the destroy function a script that is attached to the prefab itself.
}
