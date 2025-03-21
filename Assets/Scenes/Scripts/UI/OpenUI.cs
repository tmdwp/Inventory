using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI: MonoBehaviour, UIButton
{
    public UIManager uiManager;
    public GameObject ui;
    
    public void OnClickButton()
    {
        Debug.Log("click");
        ui.SetActive(true);
        uiManager.ClickButton();
    }

}
