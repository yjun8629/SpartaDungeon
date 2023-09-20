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
        //Ű����
        if (playerName.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("����2");
            InputName();
            fadeOutIn.GoMain();
        }
    }

    //���콺
    public void InputName()
    {
        Debug.Log("����");
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
    }
}
