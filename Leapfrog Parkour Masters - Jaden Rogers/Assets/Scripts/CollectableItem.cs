using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string itemName;
    [SerializeField] private Score score;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    void OnTriggerEnter(Collider other)
    {
        Managers.Inventory.AddItem(itemName);
        Destroy(this.gameObject);

        if (other.gameObject.name == "Player One")
        {
            score.PlayerOneScoreIncrease();

        }
        if (other.gameObject.name == "Player Two")
        {
            score.PlayerTwoScoreIncrease();
        }
    }

}