using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D myEnemy;
    private float moveForce=10f;
    // Start is called before the first frame update
    void Start()
    {
        myEnemy=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter();
    }

    void moveCharacter()
    {
        myEnemy.velocity=new Vector2(moveForce,0f);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with Player");
        }    
    }
}
