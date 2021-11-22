using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectitem : MonoBehaviour
{
    [SerializeField]
    private GameObject item1;

    public int progress = 0;
    public int pressure = 0;
    public int daypoint = 0;
    public int day = 0;
    public int grade = 0;
    
        
    void Start(){
        spawnitem();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (daypoint == 100){
            //Day 35, Cool 35, Night 30
            day += 1;
            daypoint = 0;
        }
        if (other.gameObject.tag == "Item1"){
            Destroy(other.gameObject);
            spawnitem();
            progress ++;
            daypoint += 5;
            pressure ++;
            Debug.Log("Progress collect:");
            
        }
        if (other.gameObject.tag == "gradeup"){
            Destroy(other.gameObject);
            grade += 10;
            daypoint += 10;
            progress ++;
            Debug.Log("grade collect");
            
        }
        if (other.gameObject.tag == "grade"){
            Destroy(other.gameObject);
            grade += 5;
            daypoint += 5;
            progress ++;
            Debug.Log("grade collect");
            
        }
        if (other.gameObject.tag == "rest"){
            Destroy(other.gameObject);
            pressure -= 20;
            if (daypoint != 100){
                daypoint = 0;
                day += 1;
            }
            daypoint += 5;
            Debug.Log("rest collect");
            
        }
    }
    private void spawnitem(){
        Debug.Log("Item spawn");
        bool itemspawn = false;
        while (!itemspawn){
            Vector3 pumpkinPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((pumpkinPosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else{
                Instantiate(item1, pumpkinPosition, Quaternion.identity);
                itemspawn = true;
            }
        }

    }

}
