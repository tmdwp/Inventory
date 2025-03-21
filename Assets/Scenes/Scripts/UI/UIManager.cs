using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventory;
    public GameObject status;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
        status.SetActive(false);
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
