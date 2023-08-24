using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Foe : MonoBehaviour
{
    public int EnemyHealth = 0;
    public static float FoeSpeed = 5f;

    private bool IsLeft;
    private bool IsRight;
    
    
    public Rigidbody2D rb;
    public AudioSource foeDamaged;
    public static int EnemyXpYield;

    public GameObject EvilKnight;
    public Animator FoeAnim;
    public GameObject AttackRange;

    public GameObject FoeDeath;

    

    // Start is called before the first frame update
    void Start()
    {
        IsRight = true;
        IsLeft = false;
        
    }
    void FoeWalk()
    {
        if (FoeSpeed != 0f)
        {
            FoeAnim.SetBool("FoeIsWalking", true);
        }
    }
    






    // Update is called once per frame
    void Update()
    {
        LevelUp.levelUp();
        FoeWalk();
        

        if (IsRight == true)
        {
            rb.velocity = new Vector2(-FoeSpeed, rb.velocity.y);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (IsLeft == true)
        {
            rb.velocity = new Vector2(FoeSpeed, rb.velocity.y);
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }

        if (EnemyHealth == 0 || EnemyHealth < 0)
        {
            Instantiate(FoeDeath, transform.position, Quaternion.identity);
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            EnemyXpYield = +LevelUp.currentXP++;
            
            Destroy(EvilKnight);
            
        }
    }

    







    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ERR")
        {
            IsRight = false;
            IsLeft = true;
        }
        else if (collision.tag == "ERL")
        {
            IsRight = true;
            IsLeft = false;

        }
        if (collision.tag == "Sword")
        {

            EnemyHealth -= LevelUp.AttackValue; 
            foeDamaged.Play();

        }

    
    }













}


