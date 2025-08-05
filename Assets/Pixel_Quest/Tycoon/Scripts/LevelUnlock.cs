using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
public class LevelUnlock : MonoBehaviour
{

    public ulong cost;
    public TextMeshPro costtext;
    public ulong bluecost;
    public ulong RedCost;
    public SpriteRenderer player;
    public playerStats playerStats;
    public TextMeshProUGUI blueText;
    public TextMeshProUGUI redText;

    private void Start()
    {
        costtext= GetComponentInChildren<TextMeshPro>();
        costtext.text = "$" + cost.ToString();
    }
     
    public void BuyPotion()
    {
        if (playerStats.money > RedCost)
        {
            player.color = Color.red;
            playerStats.money -= RedCost;
            foreach (MoneyGiver moneyGiver in GameObject.FindObjectsByType<MoneyGiver>(FindObjectsSortMode.None))
            {
                moneyGiver.timer /= 2;
            }
            RedCost*=2;
            redText.text= "$" + RedCost.ToString();
        }
        }
    public void BuybPotion()
    {
        if (playerStats.money > bluecost)
        {
            player.color = Color.blue;
            playerStats.money -= bluecost;
              foreach(MoneyGiver moneyGiver in GameObject.FindObjectsByType<MoneyGiver>(FindObjectsSortMode.None))
            {
                moneyGiver.amount *= 2;
            }
            bluecost *= 2;
            blueText.text= "$" + bluecost.ToString();
        }
    }
    }
