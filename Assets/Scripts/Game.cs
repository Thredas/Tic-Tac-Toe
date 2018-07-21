using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public static int player = 1;
    public GameObject player_wins;
    public GameObject player1_wins;
    public GameObject player2_wins;
    public GameObject player_text;
    public GameObject tie;
    public GameObject[] cube;
    public Sprite[] Sprite;

    void Update()
    {
        //Проверки на выигрыш или ничью
        if (cube[0].GetComponent<Cube>().Sprite == 0 &
            cube[4].GetComponent<Cube>().Sprite == 0 &
            cube[8].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[0].GetComponent<Cube>().Sprite == 0 &
          cube[1].GetComponent<Cube>().Sprite == 0 &
          cube[2].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[2].GetComponent<Cube>().Sprite == 0 &
          cube[4].GetComponent<Cube>().Sprite == 0 &
          cube[6].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[0].GetComponent<Cube>().Sprite == 0 &
          cube[3].GetComponent<Cube>().Sprite == 0 &
          cube[6].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[1].GetComponent<Cube>().Sprite == 0 &
          cube[4].GetComponent<Cube>().Sprite == 0 &
          cube[7].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[2].GetComponent<Cube>().Sprite == 0 &
          cube[5].GetComponent<Cube>().Sprite == 0 &
          cube[8].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[3].GetComponent<Cube>().Sprite == 0 &
          cube[4].GetComponent<Cube>().Sprite == 0 &
          cube[5].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[6].GetComponent<Cube>().Sprite == 0 &
          cube[7].GetComponent<Cube>().Sprite == 0 &
          cube[8].GetComponent<Cube>().Sprite == 0)
        {
            Player1_wins();
        }
        else if (cube[0].GetComponent<Cube>().Sprite == 1 &
            cube[4].GetComponent<Cube>().Sprite == 1 &
            cube[8].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        }
        else if (cube[0].GetComponent<Cube>().Sprite == 1 &
          cube[1].GetComponent<Cube>().Sprite == 1 &
          cube[2].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        }
        else if (cube[2].GetComponent<Cube>().Sprite == 1 &
          cube[4].GetComponent<Cube>().Sprite == 1 &
          cube[6].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        }
        else if (cube[0].GetComponent<Cube>().Sprite == 1 &
          cube[3].GetComponent<Cube>().Sprite == 1 &
          cube[6].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        }
        else if (cube[1].GetComponent<Cube>().Sprite == 1 &
          cube[4].GetComponent<Cube>().Sprite == 1 &
          cube[7].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        }
        else if (cube[2].GetComponent<Cube>().Sprite == 1 &
          cube[5].GetComponent<Cube>().Sprite == 1 &
          cube[8].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        }
        else if (cube[3].GetComponent<Cube>().Sprite == 1 &
          cube[4].GetComponent<Cube>().Sprite == 1 &
          cube[5].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        }
        else if (cube[6].GetComponent<Cube>().Sprite == 1 &
          cube[7].GetComponent<Cube>().Sprite == 1 &
          cube[8].GetComponent<Cube>().Sprite == 1)
        {
            Player2_wins();
        } else if (cube[0].GetComponent<Cube>().Sprite == -2 ||
          cube[1].GetComponent<Cube>().Sprite == -2 ||
          cube[2].GetComponent<Cube>().Sprite == -2 ||
          cube[3].GetComponent<Cube>().Sprite == -2 ||
          cube[4].GetComponent<Cube>().Sprite == -2 ||
          cube[5].GetComponent<Cube>().Sprite == -2 ||
          cube[6].GetComponent<Cube>().Sprite == -2 ||
          cube[7].GetComponent<Cube>().Sprite == -2 ||
          cube[8].GetComponent<Cube>().Sprite == -2)
        {

        }
        else
        {
            Tie();
        }

        LocalizationManager lm = new LocalizationManager();

        if (player == 1 && lm.LangIndex == 0)
        {
            player_text.GetComponent<Text>().text = "Player 1";
        }
        else if (player == 2 && lm.LangIndex == 0) {
            player_text.GetComponent<Text>().text = "Player 2";
        } else if (player == 1 && lm.LangIndex == 1)
        {
            player_text.GetComponent<Text>().text = "Первый игрок";
        }
        else if (player == 2 && lm.LangIndex == 1)
        {
            player_text.GetComponent<Text>().text = "Второй игрок";
        }
    }     
    

    void Player1_wins()
    {
        player_wins.SetActive(true);
        player1_wins.SetActive(true);
        player_text.SetActive(false);
        DisableGame();
    }

    void Player2_wins()
    {
        player_wins.SetActive(true);
        player2_wins.SetActive(true);
        player_text.SetActive(false);
        DisableGame();
        
    }

    void Tie()
    {
        player_wins.SetActive(true);
        tie.SetActive(true);
        player_text.SetActive(false);
        DisableGame();
    }

    private void DisableGame()
    {
        for (int i = 0; i < 9; i++)
        {
            Destroy(cube[i].GetComponent<Cube>());
        }
    }
}
