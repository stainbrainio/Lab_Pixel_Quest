using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
  
    public float CapsuleHeight = 0.25f;
public float CapsuleRadius = 0.08f;
public Transform feetCollider;
public LayerMask groundMask;
private bool _groundCheck;
    private float fallForce = -1;
    private Vector2 gravityforce;
    public float jumpforce =10 ;
    private Rigidbody2D Jump;
    // Start is called before the first frame update
    void Start()
    {
        Jump = GetComponent<Rigidbody2D>();
        gravityforce = new Vector2 (0f, Physics2D.gravity.y);
        

    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space)&& _groundCheck)
        {
            Jump.velocity = new Vector2(Jump.velocity.x, jumpforce);
        }
       
        
           
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius),CapsuleDirection2D.Horizontal,0,groundMask);
    }
}
