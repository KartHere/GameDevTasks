using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    SpriteRenderer sprite;
    private Color col;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        col = new Color(0.1215686f, 0.8784314f, 0.8156863f, 1.0f);
    }

    public void Changer()
    {
        // Change the 'color' property of the 'Sprite Renderer'
        sprite.color = col;
        Destroy(GetComponent<BoxCollider2D>());
    }
}
