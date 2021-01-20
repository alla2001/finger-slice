using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class  playerInfo 
{
    public static int score;
    public static void addscore()
    {
        score += 5;
        //Debug.Log(score);
        if ((score % 100) == 0)
        {


            spawner.line();
        }
    }

}
