using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private int var0ne = 1;


    private string bear = "how are you ";
    private int varTwo = 3;
    public string nextLevel = "scene_2";
    private Rigidbody2D player;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
       
        int var2 = 2;
        Debug.Log("Hello World");
        string goat = "im good how are you";
        Debug.Log(bear + goat);

    }

    // Update is called once per frame
    void Update()
    {
   
            float xInput = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(xInput*speed, player.velocity.y); 

        Debug.Log(varTwo);

        varTwo++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string ThisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(ThisLevel);
                    break;
                }
           
              case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

        }
        
    }
}
