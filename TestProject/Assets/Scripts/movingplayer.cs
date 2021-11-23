using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplayer : MonoBehaviour {
private bool isJump = false;
private Rigidbody2D rigidbody_2D;
public int jumphight = 20;
public AudioClip jumpsound;
AudioSource audiosound;
void Start () {
    rigidbody_2D = transform.GetComponent<Rigidbody2D>();
}


void Update () {
    float inputX = Input.GetAxis ("Horizontal");
    float inputY = Input.GetAxis ("Vertical");


    if (Input.GetKeyDown ("space") && isJump == false){
        //jumpsound.play();
        rigidbody_2D.velocity = Vector2.up * jumphight;
        isJump = true;
    } 
  
}
private void OnCollisionEnter2D(Collision2D other) {
    if (other.gameObject.tag == "Ground"){
        Debug.Log("Hit gound");
        isJump = false;
    }
}
}