using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerStats : MonoBehaviour
{
    //public string nextLevel = "GeoLevel_2";
    public int coinCount = 0;
    public int Health = 3;
    public Transform RespawnPoint;
    public int _maxHealth = 3;
    public PlayerUIController _playerUIController;
    // Start is called before the first frame update

    private void Start()
    {
        _playerUIController = GetComponent<PlayerUIController>();
        _playerUIController.UpdateHealth(Health,_maxHealth);
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag) 
        {

            case "Respawn":

                {
                    RespawnPoint.position = other.transform.Find("Point").position;
                    break;



                }




            case "Health":
                {
                    if (Health <= 3)
                    {
                        Destroy(other.gameObject);
                        Health++;
                        _playerUIController.UpdateHealth(Health, _maxHealth);
                    }
                    break;
                }

            case "Death":
            {
                    Health--;
                    _playerUIController.UpdateHealth(Health, _maxHealth);
                    if (Health <= 0)
                    {
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel); 
                    }

                        else
                        {
                            transform.position = RespawnPoint.position;


                        }


                   
                    
                
                    break;
            }

            case "Finish":
                {
                    string Nextlevel = other.GetComponent<LevelGoal>().Nextlevel;
                  SceneManager.LoadScene(Nextlevel); break; }


            case "Coin":
                { coinCount++;
                    Destroy(other.gameObject);
                    break;
                }

           





        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
