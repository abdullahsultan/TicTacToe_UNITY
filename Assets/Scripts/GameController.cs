using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text winText;
    public Text[] textArray;
    public Button[] gamebuttons;
    public string playerSide = "X";
    private int count = 0;


    public void CheckWin()
    {

        count++;
        if (playerSide.Equals("X"))
            playerSide = "O";
        else
            playerSide = "X";
       

        if (textArray[0].text == textArray[1].text && textArray[1].text == textArray[2].text)
        {
            winText.text = textArray[0].text + " Won";
            DisableAllButton();
        }
        else if (textArray[3].text == textArray[4].text && textArray[4].text == textArray[5].text)
        {
            winText.text = textArray[3].text + " Won";
            DisableAllButton();
        }
        else if (textArray[6].text == textArray[7].text && textArray[7].text == textArray[8].text)
        {
            winText.text = textArray[6].text + " Won";
            DisableAllButton(); 
        }
        else if (textArray[0].text == textArray[3].text && textArray[3].text == textArray[6].text)
        {
            winText.text = textArray[0].text + " Won";
            DisableAllButton();
        }
        else if (textArray[1].text == textArray[4].text && textArray[4].text == textArray[7].text)
        {
            winText.text = textArray[1].text + " Won";
            DisableAllButton();
        }
        else if (textArray[2].text == textArray[5].text && textArray[5].text == textArray[8].text)
        {
            winText.text = textArray[2].text + " Won";
            DisableAllButton();
        }
        else if (textArray[0].text == textArray[4].text && textArray[4].text == textArray[8].text)
        {
            winText.text = textArray[0].text + " Won";
            DisableAllButton();
        }
        else if (textArray[2].text == textArray[4].text && textArray[4].text == textArray[6].text)
        {
            winText.text = textArray[2].text + " Won";
            DisableAllButton();
        }
        else if (count >= 9)
        {
            winText.text = "Draw";
        }
        

    }

    public void DisableAllButton()
    {
        for(int x=0; x<9; x++)
        {
            gamebuttons[x].interactable = false;
        }
    }

}

