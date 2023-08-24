using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public static float WalkSpeed = 500f;

    private Animator PlayerAnimation;
    public Collider2D Sword;
    public Text healthvalue;

    public AudioSource PlayerIsHit;
    public static int healthpoints = 6;
    public static bool canJump;
    

    private float JumpSpeed = 1000f;
    public AudioSource SwordAttackSound;
    public int Armour;

    public Text ArmourValue;
    public AudioSource ArmourHit;
    public GameObject GameOverScreen;

    public GameObject PlayerActive;
    public AudioSource PlayerDies;
    public static Transform Aim;

    public GameObject playerDeath;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerAnimation = GetComponent<Animator>();
        Sword.enabled = false;
        healthpoints = 6;
        Armour = 6;
        GameOverScreen.SetActive(false);
        PlayerActive.SetActive(true);
        WalkSpeed = 500f;
        
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpSpeed * Time.fixedDeltaTime);
        }

    }




    // Update is called once per frame
    void FixedUpdate()
    {



        if (Input.GetKey(KeyCode.D))

        {
            rb.velocity = new Vector2(WalkSpeed * Time.fixedDeltaTime, rb.velocity.y); //The result of the input.
            PlayerAnimation.SetBool("PlayerWalking", true);
            transform.localEulerAngles = new Vector3(0, 0, 0); //Flips the character if moving negative on the X-axis.
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-WalkSpeed * Time.fixedDeltaTime, rb.velocity.y); //The result of the input.
            PlayerAnimation.SetBool("PlayerWalking", true);
            transform.localEulerAngles = new Vector3(0, 180, 0); //Flips the character if moving positive on the X-axis.

        }

        if (canJump == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpSpeed * Time.fixedDeltaTime);
            }
        
        
        
        
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FoeAxe")
        {
            if (Armour != 0)
            {
                --Armour;
                ArmourHit.Play();
            }

            if (Armour == 0)
            {
                healthpoints--;
                PlayerIsHit.Play();
            }




        }
    }






    public void OnCollisionEnter2D(Collision2D collision)
    {

        

        if (collision.gameObject.tag == "Ground")
        {

            canJump = true;
        }

        

    }

    

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            canJump = false;
        }
    }

    void GameOver()
    {
        if (healthpoints <= 0 || healthpoints == 0)
        {
            PlayerDies.Play();
            Instantiate(playerDeath, transform.position, Quaternion.identity);
            PlayerActive.SetActive(false);
            GameOverScreen.SetActive(true);



        }
    }

    void Update()
    {
        
        
        healthvalue.text = healthpoints.ToString();
        ArmourValue.text = Armour.ToString();








        













        if (Input.GetMouseButtonDown(0))
        {

            PlayerAnimation.SetTrigger("PlayerAttack");
            SwordAttackSound.Play();
            Sword.enabled = true;

            
        }
        else
        {
            
            Sword.enabled = false;
            

        }
        

        
        
        
        if (Input.GetKeyUp(KeyCode.D))
        {
            PlayerAnimation.SetBool("PlayerWalking", false);
            
            
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            PlayerAnimation.SetBool("PlayerWalking", false);
            
            
        }

        
        GameOver();
        




    }

    


}
