using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



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

    public void ResetUI() //UI Ȱ��ȭ �ʱ�ȭ
    {
        mainMenu.gameObject.SetActive(false);
        inventory.gameObject.SetActive(false);
        status.gameObject.SetActive(false);

        mainMenu.gameObject.SetActive(true);
    }

    public void OpenInven() //�κ��丮 ����
    {
            inventory.gameObject.SetActive(true);
            mainMenu.CloseButton();
    }


    public void OpenStatus() //�ɷ�ġâ ����
    {
            status.gameObject.SetActive(true);
            mainMenu.CloseButton();
    }
    public void CloseInven() //�κ��丮 �ݱ�
    {
        inventory.gameObject.SetActive(false);
        mainMenu.OpenButton();
    }

    public void CloseStatus() //�ɷ�ġâ �ݱ�
    {
        status.gameObject.SetActive(false);
        mainMenu.OpenButton();
    }
}
