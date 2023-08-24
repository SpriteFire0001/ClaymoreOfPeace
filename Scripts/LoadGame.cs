using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public GameObject ButtonLoad;
    public static int LoadLock = 0;

    private void Update()
    {
        if (LoadLock == 0)
        {
            ButtonLoad.SetActive(false);
        }
        else if (LoadLock >= 1)
        {
            ButtonLoad.SetActive(true);
        }
    }


    public void LoadGames()
    {
        


        int playerLevel = PlayerPrefs.GetInt("Level");
        int playerNextXPLevel = PlayerPrefs.GetInt("NextLevelXP");
        int playerCurrentXp = PlayerPrefs.GetInt("Xp");

        int PlayerAttack = PlayerPrefs.GetInt("Attack");
        int Part1 = PlayerPrefs.GetInt("Claymore 1");
        int Part2 = PlayerPrefs.GetInt("Claymore 2");
        
        int Part3 = PlayerPrefs.GetInt("Claymore 2");
        SceneManager.LoadScene("LevelSelect");

    }
}
