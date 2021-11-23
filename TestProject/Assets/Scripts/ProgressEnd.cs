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
    public TMP_Text Resulttext;
    // Start is called before the first frame update

    void Update()
    {
        ProgressScoretext.SetText(collectitemScript.progress.ToString() + " %");
        if (collectitemScript.progress >= 100)
        {
            checkbox.GetComponent<Image>().sprite = checktrue;
            Resulttext.SetText("Finish!");
        }
        else
        {
            checkbox.GetComponent<Image>().sprite = checkfalse;
            Resulttext.SetText("Timeout!");
        }
    }
}
