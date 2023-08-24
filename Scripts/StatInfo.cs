using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatInfo : MonoBehaviour
{
    public Text PlayerLevelValue;
    public Text PlayerAttackValue;
    public Text PlayerXPpoints;
    public Text PlayerXPremain;

    // Update is called once per frame
    void Update()
    {
        PlayerLevelValue.text = LevelUp.PlayerLevel.ToString();
        PlayerAttackValue.text = LevelUp.AttackValue.ToString();
        PlayerXPpoints.text = LevelUp.currentXP.ToString();
        PlayerXPremain.text = LevelUp.LevelUPxp.ToString();
    }
}
