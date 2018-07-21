using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationManager{

    static int langIndex = -1; // индекс языка: -1-еще не инициализирован, 0-англ, 1 - русский и т.д.

    public int LangIndex
    {
        get { return langIndex; }
        set { langIndex = value; }
    }

    public static string Translate(string text_)
    {
        if (langIndex == -1) // начальная инициализация индекса языка при первом вызове
        {
            switch (Application.systemLanguage.ToString())
            {
                case "English": langIndex = 0; break;
                case "Russian": langIndex = 1; break;
                    // продолжить для других языков ....
            }
        }

        for (int i = 0; i < labels.GetLength(0); i++)
        {
            if (text_ == labels[i, 0]) return labels[i, langIndex];
        }
        return text_;
    }


    // здесь будут все наши тексты
    static string[,] labels =
    {
    {
      "Tic Tac Toe", // англ.
      "Крестики-нолики"  // русс.
    },
    {
      "Play with friend",
      "Игра с другом"
    },
    {
      "Play with AI",
      "Игра с ИИ"
    },
    {
      "Play Online",
      "Игра по сети"
    },
    {
      "Player 1",
      "Первый игрок"
    },
    {
      "Player 2",
      "Второй игрок"
    },
    {
      "Player 1 wins!",
      "Победил первый игрок!"
    },
    {
      "Player 2 wins!",
      "Победил второй игрок!"
    },
    {
      "Tie",
      "Ничья"
    }            
    // ...... ну и т.д., если языков больше, то в каждом блоке будет больше строчек
  };

}
