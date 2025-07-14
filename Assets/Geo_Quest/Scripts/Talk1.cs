using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Talk1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit"); Debug.Log(collision.tag);
        switch (collision.tag)
        {
            case "Win":
                {
                    break;
                }
            case "Death": 
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                
                
                }
        
        }
    }
        
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
