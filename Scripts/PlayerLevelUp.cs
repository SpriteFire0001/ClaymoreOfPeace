using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelUp : MonoBehaviour
{
    public static int SwordAttack = LevelUp.AttackValue;
    public static int PlayerXP = LevelUp.currentXP;
    public static int XpToNextLevel = LevelUp.LevelUPxp;

    public static int PlayersLevel = LevelUp.PlayerLevel;

    void Update()
    {
        LevelUp.levelUp();
        Debug.Log(PlayerXP);
        Debug.Log(LevelUp.currentXP);
        Debug.Log(LevelUp.PlayerLevel);
        
        
        
    
    
    
    
    
    
    
    
    
    
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }



}
