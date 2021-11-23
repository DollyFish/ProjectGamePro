
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGscroll : MonoBehaviour
{
    public Image Daystate;
    public Sprite Morning;
    public Sprite Everning;
    public Sprite Night;

    Material material;
    Vector2 offset;
    public collectitem collectitemScript;

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
        if (stable == "Night" || stable == "Evenning" )
        {        
            if (collectitemScript.daystatus == 1)
            {
                Object.GetComponent<MeshRenderer>().material = material1;
                stable = "Day";
                Daystate.GetComponent<Image>().sprite = Morning;
            }
        }
        if (stable == "Day" || stable == "Night" )
        {
            if ( collectitemScript.daystatus == 2 )
            {
                Object.GetComponent<MeshRenderer>().material = material2;
                stable = "Evenning";
                Daystate.GetComponent<Image>().sprite = Everning;
            }
        }
        if (stable == "Day" || stable == "Evenning" )
        {
            if ( collectitemScript.daystatus == 3 )
            {
                Object.GetComponent<MeshRenderer>().material = material3;
                stable = "Night";
                Daystate.GetComponent<Image>().sprite = Night;
            }
        }  

        material = GetComponent<MeshRenderer>().material;
        material.mainTextureOffset += (offset * Time.deltaTime);
    }
}
