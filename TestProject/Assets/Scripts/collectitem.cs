using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class collectitem : MonoBehaviour
{
    [SerializeField]
    private GameObject item1;

    [SerializeField]
    TMP_Text dayText;
    public int progress = 0;
    [SerializeField] Slider progressSlider;

    public int pressure = 0;
    [SerializeField] Slider pressureSlider;

    public int daypoint = 0;
    public int day = 0;
    [SerializeField] Slider daySlider;

    public int grade = 0;
    [SerializeField] Slider gradeSlider;

    public int end = 10;
    public int daystatus = 0;    
    void Start(){
        //spawnitem();
        if (day == end){
  
            //end
        }
        if (daypoint > 0 && daypoint < 35){
            daystatus = 1;
            //Morning
        }
        if (daypoint > 35 && daypoint < 70){
            daystatus = 2;
            //Afternoon
        }
        if (daypoint > 70){
            daystatus = 3;
            //Night
        }
    }

    public void updateAllSlider()
    {
        progressSlider.value = progress;
        daySlider.value = daypoint;
        pressureSlider.value = pressure;
        gradeSlider.value = grade;
        dayText.SetText($"Day: {day}");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (daypoint == 100){
            //Day 35, Cool 35, Night 30
            day += 1;
            daypoint = 0;
        }
        if (other.gameObject.tag == "Progress"){
            Destroy(other.gameObject);
            //spawnitem();
            progress ++;
            daypoint += 5;
            pressure += 2;
            
            Debug.Log("Progress collect:");
            
        }
        if (other.gameObject.tag == "GradeUp"){
            Destroy(other.gameObject);
            grade += 10;
            daypoint += 10;
            progress ++;
            Debug.Log("grade(up) collect");
            
        }
        if (other.gameObject.tag == "Grade"){
            Destroy(other.gameObject);
            grade += 5;
            daypoint += 5;
            progress ++;
            Debug.Log("grade collect");
            
        }
        if (other.gameObject.tag == "Rest"){
            Destroy(other.gameObject);
            if (pressure > 20){
                pressure -= 20;
            }
            else if (pressure < 20){
                pressure = 0;
            }
            
            if (daypoint != 100){
                daypoint = 0;
                day += 1;
            }
            
            daypoint += 5;
            Debug.Log("rest collect");
            
        }
        if (other.gameObject.tag == "DP"){
            Destroy(other.gameObject);
            end += 1;
            Debug.Log("rest collect");
        }
        updateAllSlider();
    }
    /*private void spawnitem(){
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

    }*/



}
