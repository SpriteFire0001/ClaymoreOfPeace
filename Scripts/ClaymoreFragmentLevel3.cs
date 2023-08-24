using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaymoreFragmentLevel3 : MonoBehaviour
{
    public GameObject WonWinScreenLevel3;
    public GameObject PlayerSwitchLevel3;
    public AudioSource YouWinLevel3;


    // Update is called once per frame


    private void Start()
    {
        WonWinScreenLevel3.SetActive(false);
        PlayerSwitchLevel3.active = true;
    }



    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LevelProgress.Claymore3++;
            Destroy(gameObject);
            WonWinScreenLevel3.SetActive(true);
            PlayerSwitchLevel3.active = false;
            YouWinLevel3.Play();








        }
    }
}