using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScrip : MonoBehaviour
{

    public int scoreOneLine = 20;
    public int scoreTwoLine = 50;
    public int scoreThreeLine = 120;
    public int scoreFourLine = 200;
    private int row = 0;
    public int currentScore = 0;
    public int numberLineCleared = 0;
    

    public int scoreValue = 0;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score" + currentScore;
        if (row > 0)
        {
            //Nếu số hàng được xóa bằng 1 thì tăng điểm của 1 hàng
            if (row == 1)
            {
                currentScore += scoreOneLine + 20;
                numberLineCleared++;


            }
            else if (row == 2)
            {
                currentScore += scoreTwoLine + 30;
                numberLineCleared += 2;
            }
            else if (row == 3)
            {
                currentScore += scoreThreeLine + 40;
                numberLineCleared += 3;
            }
            else if (row == 4)
            {
                currentScore += scoreFourLine + 50;
                numberLineCleared += 4;
            }
            row = 0;

        }
    }

    public void UpdateScore()
    {
        if (row > 0)
        {
            //Nếu số hàng được xóa bằng 1 thì tăng điểm của 1 hàng
            if (row == 1)
            {
                currentScore += scoreOneLine +   2;
                numberLineCleared++;


            }
            else if (row == 2)
            {
                currentScore += scoreTwoLine  * 30;
                numberLineCleared += 2;
            }
            else if (row == 3)
            {
                currentScore += scoreThreeLine  * 40;
                numberLineCleared += 3;
            }
            else if (row == 4)
            {
                currentScore += scoreFourLine +  50;
                numberLineCleared += 4;
            }

            row = 0;
            
        }
    }



}
