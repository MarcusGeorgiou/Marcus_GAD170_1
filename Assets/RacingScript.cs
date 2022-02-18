using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    int laps = 0;
    float curLapProg = 0f;
    float reqLapProg = 100f;

    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(speed);
        }
    }

    public void GainProgress(float progress)
    {
        curLapProg += progress;
        Debug.Log("Progress gained: " + progress);
        Debug.Log("Current progress is: " + curLapProg);

        CheckProgress(curLapProg);
    }

    public void CheckProgress(float progress)
    {
        if(progress >= reqLapProg)
        {
            // Completed a lap
            LapCompleted();
        }
    }

    public void LapCompleted()
    {
        //Update lap
        laps++;

        Debug.Log("Lap Completed!");
        Debug.Log("Laps completed: " + laps);

        //Reset current progress to 0
        curLapProg = 0;

        //Increase required lap progress
        reqLapProg *= 1.15f;
    }
}
