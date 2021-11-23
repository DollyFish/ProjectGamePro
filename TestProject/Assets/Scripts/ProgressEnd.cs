using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ProgressEnd : MonoBehaviour
{
    public collectitem collectitemScript;
    public Image checkbox;
    public Sprite checktrue;
    public Sprite checkfalse;
    public TMP_Text ProgressScoretext;
    public TMP_Text Resulttext;

    public Image Grade;
    public Sprite GradeF;
    public Sprite GradeD;
    public Sprite GradeC;
    public Sprite GradeB;
    public Sprite GradeA;
    public Button restart;
    public AudioSource audiosound;

    // Start is called before the first frame update

    void Update()
    {
        ProgressScoretext.SetText(collectitemScript.progress.ToString() + " %");
        if (collectitemScript.progress >= 100)
        {
            checkbox.GetComponent<Image>().sprite = checktrue;
            Resulttext.SetText("Finish!");
            if (collectitemScript.grade < 10)
            {  
                Grade.GetComponent<Image>().sprite = GradeF;
            }

            else if (collectitemScript.grade >= 10 && collectitemScript.grade < 20)
            {  
                Grade.GetComponent<Image>().sprite = GradeD;
            }
            else if (collectitemScript.grade >= 20 && collectitemScript.grade < 30)
            {  
                Grade.GetComponent<Image>().sprite = GradeC;
            }
            else if (collectitemScript.grade >= 30 && collectitemScript.grade < 40)
            {  
                Grade.GetComponent<Image>().sprite = GradeB;
            }
            else if (collectitemScript.grade >= 40)
            {  
                Grade.GetComponent<Image>().sprite = GradeA;
            }
        }
        else
        {
            checkbox.GetComponent<Image>().sprite = checkfalse;
            Resulttext.SetText("Timeout!");
            Grade.GetComponent<Image>().sprite = GradeF;
        }
    }

    public void LoadScene(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }

    public void playsound()
    {
        audiosound.Play();
    }


    
}
