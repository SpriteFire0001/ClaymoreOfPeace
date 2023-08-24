using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Canvas Pmenu;
    private int pauseSwitch;
    

    void Start()
    {
        Pmenu.enabled = false;
        pauseSwitch = 0;
        Time.timeScale = 1f;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pauseSwitch == 0)
        {
            Pmenu.enabled = true;
            Time.timeScale = 0f;
            pauseSwitch = 1;
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseSwitch == 1)
        {
            Pmenu.enabled = false;
            Time.timeScale = 1f;
            pauseSwitch = 0;

        }












    }



}
