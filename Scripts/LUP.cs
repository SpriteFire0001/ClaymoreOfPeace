using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LUP : MonoBehaviour
{
    public GameObject LevelUpMessage;
    public int MessageTimer;
    // Start is called before the first frame update
    void Start()
    {
        LevelUpMessage.SetActive(false);
        MessageTimer = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelUp.currentXP >= LevelUp.LevelUPxp)
        {
            LevelUpMessage.SetActive(true);
            MessageTimer--;
        }

        else if (MessageTimer == 0)
        {
            LevelUpMessage.SetActive(false);
            MessageTimer = 60;
        }
        

    }
}
