using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public CharacterColor equiped;
    public GameObject origin;

    public Button back;
    void Start()
    {
        back.onClick.AddListener(UIManager.UiManager.CloseInven);
    }

   public void SwapEquip(CharacterColor newColor)
    {
        equiped = newColor;
    }

    public void UnEquip()
    {
        equiped = CharacterColor.White;
    }
}
