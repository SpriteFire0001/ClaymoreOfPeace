using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marshland : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.WalkSpeed = 156f;
            Player.canJump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Player.WalkSpeed = 500f;
            Player.canJump = false;
        }














        
    }




}
