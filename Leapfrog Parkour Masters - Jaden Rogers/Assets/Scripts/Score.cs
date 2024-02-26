using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int playerOneScore;
    public int playerTwoScore;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;
    public Text winText;

    public int winScore;
    private bool canWin = true;


    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;

        playerOneScoreText.text = ("Player One Score: " + playerOneScore.ToString());
        playerTwoScoreText.text = ("Player Two Score: " + playerTwoScore.ToString());
        winText.text = ("");

    }

    // Update is called once per frame
    void Update()
    {
        if (playerOneScore == winScore && canWin || playerTwoScore == winScore && canWin)
        {
            PlayerWin();
        }
    }

    public void PlayerOneScoreIncrease()
    {
        playerOneScore += 1;
        playerOneScoreText.text = ("Player One Score: " + playerOneScore.ToString());
    }
    public void PlayerTwoScoreIncrease()
    {
        playerTwoScore += 1;
        playerTwoScoreText.text = ("Player Two Score: " + playerTwoScore.ToString());
    }

    public void PlayerWin()
    {
        if (playerOneScore == winScore)
        {
            winText.text = ("Player One Wins!");
        }
        else if (playerTwoScore == winScore)
        {
            winText.text = ("Player Two Wins!");
        }

        canWin = false;
    }

}
