using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("Button")]
    public Button back;

    [Header("Stat")]
    public TextMeshProUGUI hp;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI defense;
    public TextMeshProUGUI critical;
    void Start()
    {
        back.onClick.AddListener(UIManager.UiManager.CloseStatus);
    }

    public void UpdateStatTxt()
    {
        hp.text = GameManager.Instance.player.GetHpFromPlayer().ToString();
        attack.text = GameManager.Instance.player.GetAttackFromPlayer().ToString();
        defense.text = GameManager.Instance.player.GetDefenseFromPlayer().ToString();
        critical.text = GameManager.Instance.player.GetCriticalFromPlayer().ToString();
    }
}
