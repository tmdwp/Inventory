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
        // Player ������ ȣ���� �ʱ�ȭ
        player = new Player(id);
        Debug.Log($"�÷��̾� ������ �ʱ�ȭ: {player.id}, ����: {player.level}, ���: {player.gold}");

        // �� UI�� ������ ����
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
