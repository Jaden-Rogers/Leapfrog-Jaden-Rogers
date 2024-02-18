using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int playerOneScore;
    int playerTwoScore;

    public int scoreCooldown = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;

        Debug.Log($"Player One Score: {playerOneScore} Player Two Score {playerTwoScore}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerOneScoreIncrease()
    {
        playerOneScore += 1;
        Debug.Log("Player One Scored!");
        Debug.Log($"Player One Score: {playerOneScore} Player Two Score {playerTwoScore}");
    }
    public void PlayerTwoScoreIncrease()
    {
        playerTwoScore += 1;
        Debug.Log("Player Two Scored!");
        Debug.Log($"Player One Score: {playerOneScore} Player Two Score {playerTwoScore}");  
    }

}
