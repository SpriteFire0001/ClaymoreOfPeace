using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    public Text PlayerDisplayLevel;
    public Text PlayerAttackDisplayLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDisplayLevel.text = LevelUp.PlayerLevel.ToString();
        PlayerAttackDisplayLevel.text = LevelUp.AttackValue.ToString();
    }
}
