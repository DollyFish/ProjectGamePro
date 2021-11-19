using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public Vector2 thrust;
    public float rb_thrust = 2.0f;
    void start()
    {
        rb = GetComponent<Rigidbody2D>();
        thrust = new Vector2(0.0f, 3.0f);
    }
    void update(){
        if (Input.GetKeyDown ("space"))
            {
                // rb is get rigid, rb_thrush is force
                Debug.Log("press");
                // rb.AddForce(thrust * rb_thrust, ForceMode2D.Impulse);
                
            }
    }

}
