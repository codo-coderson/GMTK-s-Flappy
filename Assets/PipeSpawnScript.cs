using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float pipeOffset = 10;

    void Start()
    {
        spawnPipe();
    }

    void Update() { 
        if (timer < spawnRate){
            timer = timer + Time.deltaTime;
        }    else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        float offsetNow = Random.Range(1, pipeOffset);
        Vector3 v = new Vector3(transform.position.x, offsetNow, transform.position.z);
        Instantiate(pipe, v, transform.rotation);
    }
}
