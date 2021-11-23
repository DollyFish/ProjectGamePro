using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selfdestroy : MonoBehaviour
{
    public float timebomb = 1f;

    void Update()
    {
        if (timebomb > 0)
        {
            timebomb -= Time.deltaTime;
        }
        else
        {
            Destroy(transform.gameObject);
        }
    }
}
