using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperCollision : MonoBehaviour
{
    [SerializeField] private Score score;
    [SerializeField] private PlayerCharacter playerCharacter;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && playerCharacter.PlayerOne)
        {
            score.PlayerOneScoreIncrease();
        }
        if (other.gameObject.tag == "Player" && playerCharacter.PlayerTwo)
        {
            score.PlayerTwoScoreIncrease();
        }
    }
    
}

