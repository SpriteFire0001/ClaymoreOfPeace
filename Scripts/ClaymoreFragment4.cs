using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaymoreFragment4 : MonoBehaviour
{
    public GameObject WonWinScreen4;
    public GameObject PlayerSwitch4;
    public AudioSource YouWin4;


    // Update is called once per frame


    private void Start()
    {
        WonWinScreen4.SetActive(false);
        PlayerSwitch4.active = true;
    }



    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LevelProgress.Claymore1++;
            Destroy(gameObject);
            WonWinScreen4.SetActive(true);
            PlayerSwitch4.active = false;
            YouWin4.Play();








        }
    }
}