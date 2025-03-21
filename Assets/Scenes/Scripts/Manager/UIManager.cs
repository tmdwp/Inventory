using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum WhatOpen
{
    None,
    Inven,
    Stat
}

public class UIManager : MonoBehaviour
{
    public static UIManager UiManager { get; private set; }

    public UIInventory inventory;
    public UIStatus status;
    public UIMainMenu mainMenu;

    void Awake()
    {
        if (UiManager == null)
        {
            UiManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        ResetUI();
    }

    public void ResetUI()
    {
        mainMenu.gameObject.SetActive(false);
        inventory.gameObject.SetActive(false);
        status.gameObject.SetActive(false);

        mainMenu.gameObject.SetActive(true);
    }

    public void OpenInven()
    {
            inventory.gameObject.SetActive(true);
            mainMenu.CloseButton();
    }


    public void OpenStatus()
    {
            status.gameObject.SetActive(true);
            mainMenu.CloseButton();
    }
    public void CloseInven()
    {
        inventory.gameObject.SetActive(false);
        mainMenu.OpenButton();
    }

    public void CloseStatus()
    {
        status.gameObject.SetActive(false);
        mainMenu.OpenButton();
    }
}
