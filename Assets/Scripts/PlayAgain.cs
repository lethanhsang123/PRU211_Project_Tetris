using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPlayAgainButtonClicked()
    {
        SceneManager.LoadScene("Tetris-Normal"); // "MainScene" là tên c?a scene chính c?a game
    }
}
