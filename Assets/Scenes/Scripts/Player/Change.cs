using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    [SerializeField] private Sprite[] skin;
    SpriteRenderer renderer;
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    public void ChangeSkin(CharacterColor color) //착용한 장비 외형 적용
    {
        renderer.sprite = skin[(int)color];
    }
}
