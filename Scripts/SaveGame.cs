using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    
    public void SaveFunction()
    {
        LoadGame.LoadLock++;
        PlayerPrefs.SetInt("Level", LevelUp.PlayerLevel);
        PlayerPrefs.SetInt("NextLevelXP", LevelUp.LevelUPxp);
        PlayerPrefs.SetInt("Xp", LevelUp.currentXP);
        PlayerPrefs.SetInt("Attack", LevelUp.AttackValue);

        PlayerPrefs.SetInt("Claymore 1", LevelProgress.Claymore1);
        PlayerPrefs.SetInt("Claymore 2", LevelProgress.Claymore2);
        PlayerPrefs.SetInt("Claymore 3", LevelProgress.Claymore3);


    }
}
