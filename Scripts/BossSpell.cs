using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BossSpell : MonoBehaviour
{

    private Rigidbody2D Bulletrb;
    private float spellspeed = 50f;
    private float rotateSpeed = 100f;

    public Transform playerTarget;
    




    // Start is called before the first frame update
    void Start()
    {

        Bulletrb = GetComponent<Rigidbody2D>();
        playerTarget = GameObject.Find("Player").transform;

    }

    // Update is called once per frame

    private void FixedUpdate()
    {

        

        Vector2 dir = (Vector2)playerTarget.position - Bulletrb.position;

        float RotateAmount = Vector3.Cross(dir, transform.up).z;

        Bulletrb.velocity = transform.up * spellspeed;

        dir.Normalize();

        Bulletrb.angularVelocity = -RotateAmount * rotateSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {

                Player.healthpoints--;
                Player.healthpoints--;
                Destroy(gameObject);
            }
            if (collision.gameObject.tag == "Sword")
            {
                Destroy(gameObject);


            }
            if (collision.gameObject.tag == "Wall")
            {
                Destroy(gameObject);

            }
        }
    }
}

    

















