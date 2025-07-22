using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerStats : MonoBehaviour
{
    public string nextLevel = "GeoLevel_2";
    public int coinCount = 0;
    public int Health = 3;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag) 
        {
            case "Death":
            {
                    string Thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(Thislevel);
                    break;
            }

            case "Finish":
                { SceneManager.LoadScene(nextLevel); break; }


            case "Coin":
                { coinCount++;
                    Destroy(other.gameObject);
                    break;
                }

            case "Health": {  Health++; Destroy(other.gameObject);
                    break;
                }






        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
