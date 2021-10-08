using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform shootpos;
    public GameObject bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){

        if(Input.GetKeyDown(KeyCode.E)){
            Instantiate(bullet , shootpos.transform.position , transform.rotation);
        }
        
    }
    
}
