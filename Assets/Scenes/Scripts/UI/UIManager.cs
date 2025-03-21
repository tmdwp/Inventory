using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("UIManager").AddComponent<UIManager>();
            }
            return _instance;
        }
    }

    public UIInventory inventory;
    public UIStatus status;
    public GameObject button;
    // Start is called before the first frame update

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }  
    }
    void Start()
    {
        inventory.gameObject.SetActive(false);
        status.gameObject.SetActive(false);
        button.SetActive(true);
    }

    public void ClickButton()
    {
        if (button.activeInHierarchy)
        {
            button.SetActive(false);
        }
        else
        {
            button.SetActive(true);
        }
    }
}
