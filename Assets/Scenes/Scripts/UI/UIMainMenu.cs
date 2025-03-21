using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI goldTxt;

    public Button statButton;
    public Button invenButton;
    void Start()
    {
        statButton.onClick.AddListener(UIManager.UiManager.OpenStatus);
        invenButton.onClick.AddListener(UIManager.UiManager.OpenInven);
    }

    public void UpdateStat()
    {
        nameTxt.text = GameManager.Instance.player.id;
        levelTxt.text = GameManager.Instance.player.level.ToString();
        goldTxt.text = GameManager.Instance.player.gold.ToString();
    }
    public void OpenButton()
    {
        statButton.gameObject.SetActive(true);
        invenButton.gameObject.SetActive(true);
    }
    public void CloseButton()
    {
        statButton.gameObject.SetActive(false);
        invenButton.gameObject.SetActive(false);
    }
}
