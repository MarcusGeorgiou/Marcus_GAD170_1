using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefWork : MonoBehaviour
{
    public int level;
    public float charXP;
    public float reqXP;

    // Stats
    public float charHP;
    public float charDEF;
    public float charSPD;
    public float charATK;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void InitialStats()
    {
        // Set up stats, level and xp
        level = 1;
        charXP = 0f;
        reqXP = 100f;

        charHP = 5f;
        charDEF = 1f;
        charSPD = 10f;
        charATK = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Interaction(25f);
            Debug.Log("You killed a slime, gained 25xp");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Interaction(100f);
            Debug.Log("You walked 500 miles, gained 100xp");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Interaction(70f);
            Debug.Log("You helped a civilian with a mundane task, gained 70xp");
        }
    }

    public void Interaction(float earnedXP)
    {
        // Called by button press
        GainXP(earnedXP);
    }

    public void GainXP(float gain)
    {
        // Gain xp
        charXP += gain;
    }

    public void LevelUp()
    {
        // Increase level
        if (charXP >= reqXP)
        {
            reqXP *= 1.2f;
            charXP = 0f;
            level++;

            Debug.Log("CONGRATS, you have reached level: " + level);
            Debug.Log("EXP to next level: " + reqXP);
            IncreaseStats();
        }
    }

    public void IncreaseStats()
    {
        //increase stats
        charHP += 10f;
        charDEF += 5f;
        charSPD += 2f;
        charATK += 7f;

        Debug.Log("Health: " + charHP);
        Debug.Log("Attack: " + charATK);
        Debug.Log("Defense: " + charDEF);
        Debug.Log("Speed: " + charSPD);
    }
}
