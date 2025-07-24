using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class PlayerUIController : MonoBehaviour
{
    public Image HeartImage;
    // Start is called before the first frame update
    void Start()
    {
        HeartImage = GameObject.Find("HeartImage").GetComponent<Image>();
    }

    
    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        HeartImage.fillAmount = currentHealth / maxHealth;
    }





}
