using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPlayAgainButtonClicked()
    {
        SceneManager.LoadScene("Tetris-Normal"); // "MainScene" l� t�n c?a scene ch�nh c?a game
    }
}
