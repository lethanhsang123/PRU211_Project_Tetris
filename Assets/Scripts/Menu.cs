
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void BtnPlay()
    {
        Application.LoadLevel("LevelMenu");
    }

    public void BtnOption()
    {
        Application.LoadLevel("OptionMenu");
    }

    public void BtnQuit_Option()
    {
        Application.LoadLevel("Menu game");
    }

    public void BtnHard()
    {
        Application.LoadLevel("");
    }

    public void BtnMedium()
    {
        Application.LoadLevel("Tetris-Normal");
    }
}
