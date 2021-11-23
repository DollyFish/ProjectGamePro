using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScroll : MonoBehaviour
{
    Material material;
    public Material material1;

    public Material material2;

    public int setting = 1;

    public string stable;
    Vector2 offset;

    public float xVelocity, yVelocity;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
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
                stable = "Night";
                Debug.Log("Fuckyou2");
            }
        }
        if (stable == "Night")
        {
            if (setting == 1)
            {
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
        material.mainTextureOffset += (offset * Time.deltaTime);
    }
}
