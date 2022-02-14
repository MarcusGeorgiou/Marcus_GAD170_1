using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPTest : MonoBehaviour
{
    public float CharXP;
    public float ReqXP = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Add character xp
        CharXP += 25f;

        // Display current xp
        Debug.Log("Current XP: " + CharXP);

        // Check xp against next level requirement
        if (CharXP >= ReqXP)
        {
            // Increase xp requirement
            ReqXP *= 1.5f;
            // Displey new value
            Debug.Log("Great Job, XP to next level: " + ReqXP);
        }

    }
}
