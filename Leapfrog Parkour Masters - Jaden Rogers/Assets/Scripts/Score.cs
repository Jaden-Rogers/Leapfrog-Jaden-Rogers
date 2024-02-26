using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int playerOneScore;
    public int playerTwoScore;

    public Text playerOneScoreText;
    public Text playerTwoScoreText;


    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;

        playerOneScoreText.text = ("Player One Score: " + playerOneScore.ToString());
        playerTwoScoreText.text = ("Player Two Score: " + playerTwoScore.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        
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

}
