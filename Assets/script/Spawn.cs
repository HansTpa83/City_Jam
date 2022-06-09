using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemyCar;
    Vector2 Position;
    public float SpawnRate = 1f;
    float NextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > NextSpawn)
        {
            NextSpawn = Time.time + SpawnRate;
            Position.x = Random.Range(-3.2f, 3.2f);
            Instantiate(enemyCar[Random.Range(0, 1)], Position, Quaternion.identity);
            Position.x = -Position.x;
            Instantiate(enemyCar[Random.Range(0, 1)], Position, Quaternion.identity);
        }
    }
}
