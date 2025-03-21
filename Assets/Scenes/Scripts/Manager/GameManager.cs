using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    public static GameManager Instance { get; private set; }
    [Header("Player Setting")]
    public Player player;
    public string id;

    public void SetData(string id)
    {
        // Player 생성자 호출해 초기화
        player = new Player(id);
        Debug.Log($"플레이어 데이터 초기화: {player.id}, 레벨: {player.level}, 골드: {player.gold}");

        // 각 UI에 데이터 전달
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
