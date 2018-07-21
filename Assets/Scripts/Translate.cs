using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Translate : MonoBehaviour {

    public Font ruFont;
    public Font Font;

    // Use this for initialization
    void Start () {
        Text text = gameObject.GetComponent<Text>();
        LocalizationManager lm = new LocalizationManager();
        if (text) text.text = LocalizationManager.Translate(text.text);

        if(lm.LangIndex == 1)
        {
            text.font = ruFont;
        } else
        {
            text.font = Font;
        }
    }
}
