using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHighlighter : MonoBehaviour
{

    public Button[] buttons;


    // Start is called before the first frame update
    void Start()
    {
        buttons = GetComponentsInChildren<Button>();

        foreach (Button button in buttons)
        {
            button.onClick.AddListener(delegate { MenuClicked(button); } );
        }
    }

    void MenuClicked(Button clickedButton)
    {

        foreach (Button button in buttons)
        {
            if (button == clickedButton)
            {
                HighlightButton(button, Color.white);
            }
            else{
                HighlightButton(button, Color.grey);
            }
        }
    }


    void HighlightButton(Button button, Color color)
    {
        ColorBlock colors = button.colors;
        colors.normalColor = color;
        button.colors = colors; 
    }


}
