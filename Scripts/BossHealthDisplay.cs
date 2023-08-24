using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthDisplay : MonoBehaviour
{
    public TextMesh BossHP;


    // Update is called once per frame
    void Update()
    {
        BossHP.text = FinalBoss.BossHealth.ToString();
    }
}
