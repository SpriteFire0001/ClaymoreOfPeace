using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasmDeath : MonoBehaviour
{
    public GameObject PlayerFalling;
    public GameObject FallingGameOverScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerFalling.SetActive(false);
            FallingGameOverScreen.SetActive(true);
        }
    }
}
