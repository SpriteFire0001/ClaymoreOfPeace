using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public static int currentXP = 0;
    public static int LevelUPxp = 0;
    public static int PlayerLevel = 1;

    public static int AttackValue;
    public static bool StopLeveling;

    


    static public void levelUp()
    {
        if (currentXP > LevelUPxp)
        {
            currentXP = LevelUPxp - currentXP;
            PlayerLevel++;
            Debug.Log("LevelUp!");
            LevelUPxp += LevelUPxp / 20;
        }


        if (PlayerLevel == 1)
        {
            LevelUPxp = 60;
            AttackValue = 1;
            
        
        }
        if (PlayerLevel == 2)
        {
            LevelUPxp = 120;
            AttackValue = 2;
        }

        if (PlayerLevel == 3)
        {
            LevelUPxp = 150;
            AttackValue = 3;
        }

        if (PlayerLevel == 4)
        {
            LevelUPxp = 180;
            AttackValue = 4;
        }

        if (PlayerLevel == 5)
        {
            LevelUPxp = 225;
            AttackValue = 5;
        }

        if (PlayerLevel == 6)
        {
            LevelUPxp = 225;
            AttackValue = 6;
        }
        
        if (PlayerLevel == 7)
        {
            LevelUPxp = 281;
            AttackValue = 7;
        }

        if (PlayerLevel == 8)
        {
            LevelUPxp = 351;
            AttackValue = 8;
        }

        if (PlayerLevel == 9)
        {
            LevelUPxp = 439;
            AttackValue = 8;
        }

        if (PlayerLevel == 10)
        {
            LevelUPxp = 549;
            AttackValue = 9;
        }

        if (PlayerLevel == 11)
        {
            LevelUPxp = 686;
            AttackValue = 10;
        }
        if (PlayerLevel == 12)
        {
            LevelUPxp = 857;
            AttackValue = 11;
        }
        if (PlayerLevel == 12)
        {
            LevelUPxp = 857;
            AttackValue = 12;
        }
        if (PlayerLevel == 13)
        {
            LevelUPxp = 1071;
            AttackValue = 13;
        }
        if (PlayerLevel == 14)
        {
            LevelUPxp = 1338;
            AttackValue = 14;
        }
        if (PlayerLevel == 15)
        {
            LevelUPxp = 1672;
            AttackValue = 15;
        }
        if (PlayerLevel == 16)
        {
            LevelUPxp = 2090;
            AttackValue = 16;
        }
        if (PlayerLevel == 17)
        {
            LevelUPxp = 2612;
            AttackValue = 17;
        }
        if (PlayerLevel == 18)
        {
            LevelUPxp = 3265;
            AttackValue = 18;

        }
        if (PlayerLevel == 19)
        {
            LevelUPxp = 4081;
            AttackValue = 19;

        }
        if (PlayerLevel == 20)
        {
            LevelUPxp = 5101;
            AttackValue = 20;

        }









    }



    
}
