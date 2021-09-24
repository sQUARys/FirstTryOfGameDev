using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 movevector;
    public float movespeed = 15f;
    public float jumpforce = 5f;
    public Transform GroundCheck; // обьект земли который мы принимаем
    public float checkRadius = 0.2f;
    public LayerMask Ground; // название слоя
    public bool OnGround; 


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate(){
        walk();
        jump();
        CheckingGround();
    }

    void walk(){
        movevector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movevector.x * movespeed , rb.velocity.y);
    }

    void jump(){
        if (Input.GetKey(KeyCode.Space) && OnGround){
            rb.velocity = new Vector2(rb.velocity.x , jumpforce);
        }
    }

    void CheckingGround(){
        OnGround = Physics2D.OverlapCircle(GroundCheck.position , checkRadius , Ground); // коллайдер с позицией определенного радиуса и с Лэйаутом Граунд
    }
}
