using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class collectitem : MonoBehaviour
{
    public AudioSource collect_item;
    [SerializeField]
    private GameObject item1;

    [SerializeField]
    TMP_Text dayText;

    [SerializeField]
    TMP_Text deadline_text;

    [SerializeField]
    TMP_Text Garde_text;

    public float progress = 0;
    [SerializeField] Slider progressSlider;

    public int pressure = 0;
    [SerializeField] Slider pressureSlider;
    public int deadline = 0;
    public int daypoint = 0;
    public int day = 0;
    [SerializeField] Slider daySlider;

    public int grade = 0;
    [SerializeField] Slider gradeSlider;

    public int end = 10;
    public int daystatus = 0;
    public bool PS_status = false;    
    private string textgrade;
    void Start(){
        //spawnitem();
       
    }

    public void updateAllSlider()
    {
        progressSlider.value = progress;
        daySlider.value = deadline;
        pressureSlider.value = pressure;
        gradeSlider.value = grade;
        dayText.SetText($"Day: {day}");
        deadline_text.SetText($"{end}");
        if (pressure >= 100){
            PS_status = true;
        }
        else if (grade >= 10 && grade < 20){
            textgrade = "D";
        }
        else if (grade >= 20 && grade < 30){
            textgrade = "C";
        }
        else if (grade >= 30 && grade < 40){
            textgrade = "B";
        }
        else if (grade >= 40){
            textgrade = "A";
        }
        Garde_text.SetText($"{textgrade}");

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

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (daypoint % 100 == 0){
            //Day 35, Cool 35, Night 30
            day += 1;
            daypoint = 0;
            
        }
        if (other.gameObject.tag == "Progress"){
            //collect_item.play();
            Destroy(other.gameObject);
            //spawnitem();
            if (PS_status){
                progress += 0.5f;
            }
            else{
                progress += 1f;
            }
            
            daypoint += 5;
            deadline += 5;
            pressure += 2;
            
            Debug.Log("Progress collect:");
            
        }
        if (other.gameObject.tag == "GradeUp"){
            //collect_item.play();
            Destroy(other.gameObject);
            grade += 10;
            daypoint += 10;
            deadline += 10;
            progress ++;
            Debug.Log("grade(up) collect");
            
        }
        if (other.gameObject.tag == "Grade"){
            //collect_item.play();
            Destroy(other.gameObject);
            grade += 5;
            daypoint += 5;
            deadline += 5;
            progress ++;
            Debug.Log("grade collect");
            
        }
        if (other.gameObject.tag == "Rest"){
            //collect_item.play();
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
            //collect_item.play();
            Destroy(other.gameObject);
            end += 1;
            Debug.Log("rest collect");
        }
        updateAllSlider();
    }



}
