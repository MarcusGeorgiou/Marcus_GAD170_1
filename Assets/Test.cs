using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int fuel = 100;
    public float lapProg;
    public float reqLapProg = 200f;
    public int laps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Check current fuel
      // If fuel more than 0, increase progress and remove fuel
      if(fuel > 0)
        {
            // Increase progression
            lapProg += 5;
            // Decrease fuel
            fuel--;
        }
        else
        {
            //Out of fuel
            Debug.Log("Bad Luck, No fuel =(");
        }
      // If enough progress then lap
      if(lapProg >= reqLapProg)
        {
            //Reset progress
            lapProg = 0;
            //Increase laps
            laps++;
        }
        Debug.Log("Current fuel: " + fuel);
        Debug.Log("Lap number: " + laps);
    }
}
