using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour, UIButton
{
    public GameObject parent;
    public UIManager manager;
    public void OnClickButton()
    {
        manager.ClickButton();
        parent.SetActive(false);
    }

}
