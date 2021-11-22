using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disspawn : MonoBehaviour
{
    //private void OnCollisionEnter2D(Collision2D other) {
 
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Disspawn"){
            Debug.Log("Hit");
            Destroy(transform.gameObject);
        }
    }
   
}
