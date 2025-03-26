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

    public void ResetUI() //UI 활성화 초기화
    {
        mainMenu.gameObject.SetActive(false);
        inventory.gameObject.SetActive(false);
        status.gameObject.SetActive(false);

        mainMenu.gameObject.SetActive(true);
    }

    public void OpenInven() //인벤토리 열기
    {
            inventory.gameObject.SetActive(true);
            mainMenu.CloseButton();
    }


    public void OpenStatus() //능력치창 열기
    {
            status.gameObject.SetActive(true);
            mainMenu.CloseButton();
    }
    public void CloseInven() //인벤토리 닫기
    {
        inventory.gameObject.SetActive(false);
        mainMenu.OpenButton();
    }

    public void CloseStatus() //능력치창 닫기
    {
        status.gameObject.SetActive(false);
        mainMenu.OpenButton();
    }
}
