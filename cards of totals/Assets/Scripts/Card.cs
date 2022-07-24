using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    public bool hasBeenPlayed;
    public int cardNumber;

    public bool hidden;
    public Sprite hiddenSprite;
    private Sprite currentSprite;
    private SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentSprite = spriteRenderer.sprite;
    }

    void Update() {
        if(hidden)
            spriteRenderer.sprite = hiddenSprite;
        else
            spriteRenderer.sprite = currentSprite;

    }

    void OnMouseDown() {
        if(hidden)
            hidden = false;
        else
            hidden = true;
    }

}
