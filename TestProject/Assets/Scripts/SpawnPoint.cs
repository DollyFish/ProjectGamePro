
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject Chicken;
    public GameObject Chicken2;
    public collectitem ciscript;
    // Start is called before the first frame update
    void Start()
    {
        if (ciscript.day == ciscript.end){
            
        }
        else{
             Instantiate(Chicken, transform.position, Quaternion.identity);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
