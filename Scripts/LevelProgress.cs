using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelProgress : MonoBehaviour
{
    public static int Claymore1;
    public static int Claymore2;
    public static int Claymore3;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;


    

    // Update is called once per frame
    void Update()
    {
        if (Claymore1 == 0)
        {
            Level2.SetActive(false);
        }
        else if (Claymore1 >= 1)
        {
            Level2.SetActive(true);
        }
        if (Claymore2 == 0)
        {
            Level3.SetActive(false);
        }
        else if (Claymore2 >= 1)
        {
            Level3.SetActive(true);
        }
        if (Claymore3 == 0)
        {
            Level4.SetActive(false);
        }
        else if (Claymore3 >= 1)
        {
            Level4.SetActive(true);
        }
    }
}
