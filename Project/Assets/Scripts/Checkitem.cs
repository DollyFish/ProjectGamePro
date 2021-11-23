using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkitem : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Progress" || other.gameObject.tag == "GradeUp" || other.gameObject.tag == "Grade" || other.gameObject.tag == "Rest" || other.gameObject.tag == "DP")
        {
            Destroy(transform.gameObject);
        }
    }
}
