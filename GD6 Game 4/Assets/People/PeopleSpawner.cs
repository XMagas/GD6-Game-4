using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawner : MonoBehaviour
{

    public float SpawnDelay = .3f;

    float NextTimeToSpawn = 0f;

    float CountDownTimer = 3f;

    public GameObject people;

    public Transform[] SpawnPoints;

    void Update()
    {

        if (NextTimeToSpawn >= Time.time)
        {
            
            Spawnpeople();
            NextTimeToSpawn = Time.time + SpawnDelay;
        }






    }


    void Spawnpeople()
    {

        int RandomIndex = Random.Range(0, SpawnPoints.Length);
        Transform SpawnPoint = SpawnPoints[RandomIndex];


        Instantiate(people, SpawnPoint.position, SpawnPoint.rotation);









    }




}
