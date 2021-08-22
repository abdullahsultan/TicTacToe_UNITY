using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button button;
    public Text buttontext;
    public GameController Gobject;
    

    public void SetSpace()
    {
        buttontext.text = Gobject.playerSide;
        button.interactable = false;
        Gobject.CheckWin();
    }
}
