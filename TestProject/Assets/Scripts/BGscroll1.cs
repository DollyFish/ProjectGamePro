
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll1 : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public Material material1;

    public Material material2;

    public Material material3;

    public GameObject Object;

    public int setting = 1;

    public string stable;

    public float xVelocity, yVelocity;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    // Start is called before the first frame update1
    void Start()
    {
        offset = new Vector2(xVelocity, yVelocity);
        stable = "Day";
    }

    // Update is called once per frame
    void Update()
    {
        if (stable == "Day" || stable == "Evenning")
        {
            if (setting == 2)
            {
                Object.GetComponent<MeshRenderer>().material = material2;
                stable = "Night";
                Debug.Log("Fuckyou2");
            }
        }
        if (stable == "Night")
        {        
            if (setting == 1)
            {
                Object.GetComponent<MeshRenderer>().material = material1;
                stable = "Day";
                Debug.Log("Fuckyou");
            }

            if (Input.GetKeyDown ("space"))
            {
                // rb is get rigid, rb_thrush is force
                Debug.Log("press");
                // rb.AddForce(thrust * rb_thrust, ForceMode2D.Impulse);
                
            }
        }

        material = GetComponent<MeshRenderer>().material;
        material.mainTextureOffset += (offset * Time.deltaTime);
    }
}
