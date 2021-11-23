
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class collectitem : MonoBehaviour
{
    //public AudioClip collect_sound;
    public AudioSource audiosound;
    

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
    private bool status = true;
    

    public int grade = 0;


    public int end = 7;
    public int daystatus = 0;
    public bool PS_status = false;    
    public string textgrade = "F";

    public Spawnpattern spawning1;
    public Spawnpattern spawning2;
    public Spawnpattern spawning3;
    public Spawnpattern spawning4;
    [SerializeField] GameObject Endcanvas;
    public movingplayer playerjump;
    
    void Start(){
        //spawnitem();
       
    }

    public void updateAllSlider()
    {
        progressSlider.value = progress;
        
        pressureSlider.value = pressure;

        dayText.SetText($"Day {day}");
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
        else {
            textgrade = "F";
        }
        Garde_text.SetText($"{textgrade}");


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
        if (status == true)
        {
            if (daypoint % 100 == 0){
                //Day 35, Cool 35, Night 30
                day += 1;
                daypoint = 0;
                
            }
            if (other.gameObject.tag == "Progress"){  
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

                Destroy(other.gameObject);
                grade += 10;
                daypoint += 10;
                deadline += 10;
                progress ++;
                Debug.Log("grade(up) collect");
                
            }
            if (other.gameObject.tag == "Grade"){

                Destroy(other.gameObject);
                grade += 5;
                daypoint += 5;
                deadline += 5;
                progress ++;
                Debug.Log("grade collect");
                
            }
            if (other.gameObject.tag == "Rest"){

                Destroy(other.gameObject);
                if (pressure > 30){
                    pressure -= 30;
                }
                else if (pressure < 30){
                    pressure = 0;
                }
                
                if (daypoint != 100){
                    if (deadline % 100 != 0){
                        for (int i = 0; i < 100; i++){
                            if (deadline % 100 != 0){
                                deadline++;
                            }
                            else {
                                break;
                            }
                        }
                    }
                    daypoint = 0;
                    day ++;
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
            audiosound.Play();
        }

    }

    void Update()
    {
        if (day >= end){
            Debug.Log("Ending");
            spawning1.enabled = false;
            spawning2.enabled = false;
            spawning3.enabled = false;
            spawning4.enabled = false;
            playerjump.enabled = false;
            status = false;
            Endcanvas.SetActive(true);
            //end
        }
    }

}
