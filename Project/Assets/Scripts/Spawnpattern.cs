using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpattern : MonoBehaviour
{
    public GameObject[] spawnPatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    public int counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            if (counter == 1){
                timeBtwSpawn = startTimeBtwSpawn;
                counter--;
            }
            else{
                int rand = Random.Range(0, spawnPatterns.Length);
                Instantiate(spawnPatterns[rand], transform.position, Quaternion.identity);
                timeBtwSpawn = startTimeBtwSpawn;
                if (startTimeBtwSpawn > minTime)
                {
                    startTimeBtwSpawn -= decreaseTime;
            }
            }
            
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}