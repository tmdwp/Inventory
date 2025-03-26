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

    //플레이어 데이터 생성
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

    //플레이어 관련 UI 갱신
    public void UpdateAllUI()
    {
        if(UIManager.UiManager != null)
        {
            UIManager.UiManager.mainMenu.UpdateStat();
            UIManager.UiManager.status.UpdateStatTxt();
        }
    }
}
