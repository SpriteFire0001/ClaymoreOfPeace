using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    public GameObject ControlsScreen;
    private int controlswitch;

    private void Start()
    {
        ControlsScreen.SetActive(false);
        controlswitch = 0;
    }

    public void ControlsSelect()
    {
        if (controlswitch == 0)
        {
            ControlsScreen.SetActive(true);
            controlswitch = 1;

        }
        else if (controlswitch == 1)
        {
            ControlsScreen.SetActive(false);
            controlswitch = 0;




        }










        

        




    }





}
