using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    public GameObject Slide1, Slide2, Slide3, Slide4, Slide5, Slide6;
    private int slideNumber;
    public Text Continue;
    private void Start()
    {
        Slide1.SetActive(true);
        Slide2.SetActive(false);
        Slide3.SetActive(false);
        Slide4.SetActive(false);
        Slide5.SetActive(false);
        Slide6.SetActive(false);
        slideNumber = 1;
        Continue.text = "Continue";
    }
    public void IntroductionProgression()
    {
        slideNumber++;

        if (slideNumber == 2)
        {
            Slide1.SetActive(false);
            Slide2.SetActive(true);
            Slide3.SetActive(false);
            Slide4.SetActive(false);
            Slide5.SetActive(false);
            Slide6.SetActive(false);
            Continue.text = "Continue";

        }
        else if (slideNumber == 3)
        {
            Slide1.SetActive(false);
            Slide2.SetActive(false);
            Slide3.SetActive(true);
            Slide4.SetActive(false);
            Slide5.SetActive(false);
            Slide6.SetActive(false);
            Continue.text = "Continue";

        }
        else if (slideNumber == 4)
        {
            Slide1.SetActive(false);
            Slide2.SetActive(false);
            Slide3.SetActive(false);
            Slide4.SetActive(true);
            Slide5.SetActive(false);
            Slide6.SetActive(false);
            Continue.text = "Continue";

        }
        else if (slideNumber == 5)
        {
            Slide1.SetActive(false);
            Slide2.SetActive(false);
            Slide3.SetActive(false);
            Slide4.SetActive(false);
            Slide5.SetActive(true);
            Slide6.SetActive(false);
            Continue.text = "Continue";

        }
        else if (slideNumber == 6)
        {
            Slide1.SetActive(false);
            Slide2.SetActive(false);
            Slide3.SetActive(false);
            Slide4.SetActive(false);
            Slide5.SetActive(false);
            Slide6.SetActive(true);
            Continue.text = "Start Adventure";

        }
        else if (slideNumber == 7)
        {
            SceneManager.LoadScene("LevelSelect");
            slideNumber = 1;
        }














    }
}
