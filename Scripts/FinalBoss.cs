using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{
    public GameObject FinalClaymore;
    public static int BossHealth;
    public int BossAttackTimer;

    public Animator BossAnim;
    public GameObject BossProjectile;
    public Transform SpellHand;

    public GameObject BossDeathEffects;
    public AudioSource BossHitSound;

    // Start is called before the first frame update
    void Start()
    {
        FinalClaymore.SetActive(false);
        BossHealth = 200;
        BossAttackTimer = 0;      
    }

    // Update is called once per frame
    void Update()
    {
        BossAttackTimer++;
        BossAttack();
        BossDeath();
    }

    void BossAttack()
    {
        if (BossAttackTimer == 250)
        {
            BossAnim.SetBool("IsCasting", true);
            Instantiate(BossProjectile, transform.position, transform.rotation);
        }
        else if (BossAttackTimer == 300)
        {
            BossAnim.SetBool("IsCasting", false);
            BossAttackTimer = 0;
        }
    }


    void BossDeath()
    {
        if (BossHealth <= 0)
        {
            Instantiate(BossDeathEffects, transform.position, Quaternion.identity);
            Destroy(gameObject);
            FinalClaymore.SetActive(true);
        
        
        
        
        }
    }






    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sword")
        {
            BossHitSound.Play();
            BossHealth -= LevelUp.AttackValue;
        
        }
    }














}