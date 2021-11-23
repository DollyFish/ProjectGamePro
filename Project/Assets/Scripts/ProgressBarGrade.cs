using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode()]
public class ProgressBarGrade : MonoBehaviour
{
    public int maximum;
    public int current;
    public collectitem collectitemScript;

    public Image mask;  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }
    void GetCurrentFill(){
        
        float fillAmount = (float)collectitemScript.grade/ 40f;
        mask.fillAmount = fillAmount;
    }
}
