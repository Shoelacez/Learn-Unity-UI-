using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth=100;
    public int currentHealth;
    public HealthBar healthBarScript;

    private Vector3 movement;
    private Rigidbody2D myPlayer;
    private float moveForce=11f;
    private float movementX,movementY;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth=maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
        myPlayer=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void MovePlayer()
    {
        movementX=Input.GetAxisRaw("Horizontal");
        movementY=Input.GetAxisRaw("Vertical");

        transform.position+=new Vector3(movementX,movementY,0f)*moveForce*Time.deltaTime;
        
    }

    void TakeDamage(int damage)
    {
        currentHealth-=damage;

        healthBarScript.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Pickable"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Player has picked a heart");
        }
    }
}
