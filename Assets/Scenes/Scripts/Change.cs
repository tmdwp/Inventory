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
    public void ChangeSkin(CharacterColor color)
    {
        renderer.sprite = skin[(int)color];
    }
}
