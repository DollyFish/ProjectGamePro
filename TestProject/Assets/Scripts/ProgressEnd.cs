using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressEnd : MonoBehaviour
{
    public collectitem collectitemScript;
    public Image checkbox;
    public Sprite checktrue;
    public Sprite checkfalse;
    public TMP_Text ProgressScoretext;
    // Start is called before the first frame update

    void Update()
    {
        ProgressScoretext.SetText("Progress: " + collectitemScript.progress.ToString() + " %");
        if (collectitemScript.progress >= 100)
        {
            checkbox.GetComponent<Image>().sprite = checktrue;
        }
        else
        {
            checkbox.GetComponent<Image>().sprite = checkfalse;
        }
    }
}
