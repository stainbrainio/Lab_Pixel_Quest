using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class PlayerUIController : MonoBehaviour
{

    public Image heartImage;
    public TextMeshProUGUI coinText;

    public void StartUI()
    {
        heartImage = GameObject.Find("heart").GetComponent<Image>();
        coinText = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();

    }

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth; }



        // Update is called once per frame
        public void UpdateCoin(string newText)
    {
        coinText.text = newText;
    }
        
        
        
    }
 

