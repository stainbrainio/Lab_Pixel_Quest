using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private int coinsInLevel = 0;
    public Transform respawnPoint;
    public int Health = 3;
    public int coinCount = 0;
    public int maxHealth = 3;
    private PlayerUIController playerUIController;

    private void Start()
    {
         playerUIController = GetComponent<PlayerUIController>();
        playerUIController.StartUI();
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
        playerUIController.UpdateCoin(coinCount + "/" + coinsInLevel);
        playerUIController.UpdateHealth(Health, maxHealth);
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Respawn":
                {
                    respawnPoint.position = collision .transform.Find ("Point").position;
                    break;
                }
            case "Death":
                { 

                    
                    if (Health <= 0)
                    {
                        string ThisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(ThisLevel);
                        playerUIController.UpdateHealth(Health, maxHealth);
                            }

                    else
                    {
                        transform.position = respawnPoint.position;
                    }
                        break;
                    
                }

            case "Finish":
                {
                    string nextLevel = collision.GetComponent<LevelGoal>().Nextlevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    coinCount++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "Health":
                {
                    Health++;
                    Destroy(collision.gameObject);
                    break;
                    playerUIController.UpdateHealth(Health, maxHealth);
                }

        }
                
        }

    }

