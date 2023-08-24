using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaymoreFragment2 : MonoBehaviour
{
    public GameObject WonWinScreenLevel2;
    public GameObject PlayerSwitchLevel2;
    public AudioSource YouWinLevel2;

    // Update is called once per frame


    private void Start()
    {
        WonWinScreenLevel2.SetActive(false);
        PlayerSwitchLevel2.active = true;
    }



    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            LevelProgress.Claymore2++;
            WonWinScreenLevel2.SetActive(true);
            PlayerSwitchLevel2.active = false;
            YouWinLevel2.Play();

        }
    }
}