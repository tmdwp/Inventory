using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI hp;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI defense;
    public TextMeshProUGUI critical;
    void Start()
    {
        UpdateStatTxt();
    }

    public void UpdateStatTxt()
    {
        hp.text = Player.Instance.GetHp().ToString();
        attack.text = Player.Instance.GetAttack().ToString();
        defense.text = Player.Instance.GetDefense().ToString();
        critical.text = Player.Instance.GetCritical().ToString();
    }
}
