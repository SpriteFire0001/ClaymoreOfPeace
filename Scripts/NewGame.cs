using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void ToIntroductionScene()
    {
        SceneManager.LoadScene("Introduction");
        LevelProgress.Claymore1 = 0;
        LevelProgress.Claymore2 = 0;
        LevelProgress.Claymore3 = 0;

        LevelUp.PlayerLevel = 1;
        LevelUp.currentXP = 0;
        LevelUp.LevelUPxp = 0;
    
    }




}
