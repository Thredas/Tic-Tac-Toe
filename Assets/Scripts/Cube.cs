using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Sprite[] sprites;
    bool isPressed = false;
    public int Sprite = -2;

    void OnMouseDown()
    {
        if (Game.player == 1 & isPressed == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
            Sprite = 0;
            isPressed = true;
            Game.player = 2;
        }

        if (Game.player == 2 & isPressed == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
            Sprite = 1;
            isPressed = true;
            Game.player = 1;
        }
    }
}
