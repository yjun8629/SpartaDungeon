using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("# Main Info")]
    public Text Name;
    public Text Gold;

    [Header("# Button")]
    public Button StatusButton;
    public Button InventoryButton;
    public Button StatusToMain;
    public Button InventoryToMain;

    [Header("# Panel")]
    public Canvas StatusPanel;
    public Canvas InventoryPanel;

    [Header("# Status Info")]
    public Text Level;
    public Text Atk;
    public Text Def;

    [Header("# Inventory Info")]
    public Text SwordEquip;
    public Text ShieldEquip;
    public Button Sword;
    public Button Shield;

    bool isEquipSword = false;
    bool isEquipShield = false;

    int playerAtk = 5;
    int playerDef = 5;

    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        Name.text = PlayerPrefs.GetString("CurrentPlayerName");
        Gold.text = "¼ÒÁö±Ý: " + "1000";
        Level.text = "LV. " + "1";
        Atk.text = "ATK: " + $"{playerAtk}";
        Def.text = "DEF: " + $"{playerDef}";

        StatusToMain.onClick.AddListener(GoMain);
        InventoryToMain.onClick.AddListener(GoMain);
        StatusButton.onClick.AddListener(GoStatusPanel);
        InventoryButton.onClick.AddListener(GoInventoryPanel);

        Sword.onClick.AddListener(EquipSword);
        Shield.onClick.AddListener(EquipShield);
    }

    public void GoMain()
    {
        StatusPanel.gameObject.SetActive(false);
        InventoryPanel.gameObject.SetActive(false);
        StatusButton.gameObject.SetActive(true);
        InventoryButton.gameObject.SetActive(true);
    }

    public void GoStatusPanel()
    {
        StatusPanel.gameObject.SetActive(true);
        StatusButton.gameObject.SetActive(false);
        InventoryButton.gameObject.SetActive(false);
    }

    public void GoInventoryPanel()
    {
        InventoryPanel.gameObject.SetActive(true);
        StatusButton.gameObject.SetActive(false);
        InventoryButton.gameObject.SetActive(false);
    }

    public void EquipSword()
    {
        if (isEquipSword == false)
        {
            SwordEquip.gameObject.SetActive(true);
            isEquipSword = true;
            playerAtk += 5;
        }
        else
        {
            SwordEquip.gameObject.SetActive(false);
            isEquipSword = false;
            playerAtk -= 5;
        }
    }

    public void EquipShield()
    {
        if (isEquipShield == false)
        {
            ShieldEquip.gameObject.SetActive(true);
            isEquipShield = true;
            playerDef += 5;
        }
        else
        {
            ShieldEquip.gameObject.SetActive(false);
            isEquipShield = false;
            playerDef -= 5;
        }
    }
}
