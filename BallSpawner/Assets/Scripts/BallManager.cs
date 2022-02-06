using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{

    public List<GameObject> spawnList;
    public List<GameObject> spawnedBalls;
    public int ballsSpawned;
    private GameObject objectToSpawn;
    public Text ballDisplay;
    public string ballString;

    public Transform spawnLocation;

    // Encapsulation
    public GameObject ObjectForSpawn
    {
        get{return objectToSpawn;}
        set{objectToSpawn = value;}
    }

    void Update()
    {
        if (ballsSpawned > 5)
        {
            ActivateCount();
        }
    }

    public void Spawn()
    {
        int randomBall = Random.Range(0, spawnList.Count);
        ObjectForSpawn = spawnList[randomBall];
        Instantiate(objectToSpawn, spawnLocation.position, Quaternion.identity);
        spawnedBalls.Add(objectToSpawn);
        ballsSpawned ++;
    }

    // Abstraction
    public void ActivateCount()
    {
        Spawn();
        ballsSpawned = 0;
    }

}
