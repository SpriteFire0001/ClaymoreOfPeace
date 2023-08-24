using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaymoreFragment : MonoBehaviour
{
    public GameObject WonWinScreen;
    public GameObject PlayerSwitch;
    public AudioSource YouWin;
    

    // Update is called once per frame


    private void Start()
    {
        WonWinScreen.SetActive(false);
        PlayerSwitch.active = true;
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
            WonWinScreen.SetActive(true);
            PlayerSwitch.active = false;
            YouWin.Play();
            
            

            
            


            
        }
    }
}
