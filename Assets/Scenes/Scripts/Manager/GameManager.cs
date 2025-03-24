using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    public static GameManager Instance { get; private set; }
    [Header("Player Setting")]
    public Player player;
    public Sprite playerSprite;
    public string id;
    public Change skin;
    public List<ItemData> itemList;

    public void SetData(string id)
    {
        player = new Player(id);
        foreach (ItemData item in itemList) 
        {
            player.GetItem(item);
        }
        UpdateAllUI();
    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetData(id);
    }

    public void UpdateAllUI()
    {
        if(UIManager.UiManager != null)
        {
            UIManager.UiManager.mainMenu.UpdateStat();
            UIManager.UiManager.status.UpdateStatTxt();
        }
    }
}
