using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName = null;
    public FadeOutIn fadeOutIn;

    private void Awake()
    {

    }

    private void Update()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        //Å°º¸µå
        if (playerName.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("À¸¾Ç2");
            InputName();
            fadeOutIn.GoMain();
        }
    }

    //¸¶¿ì½º
    public void InputName()
    {
        Debug.Log("À¸¾Ç");
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
    }
}
