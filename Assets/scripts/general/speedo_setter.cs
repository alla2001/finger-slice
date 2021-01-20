using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedo_setter : MonoBehaviour
{

    [Range(0f, 1f)]
    public float speed;
    [Range(0f, 2f)]
    public float speedchange;
    [Range(0f,5f)]
    public float Time;
    [Range(0f, 12)]
    public  float Time_speed;
    [Range(-10f, 10f)]
    public  float rotatspeed = 5f;
    [Range(0f, 1f)]
    public  float rotatspeedchange = 0.1f;


    private void Start()
    {
        speedgoloba.speed = -speed;
        speedgoloba.Time = Time * 0.1f;
        speedgoloba.rotatspeed = rotatspeed * 0.1f;
    }

    private void FixedUpdate()
    {
        
        speedgoloba.speed -= speedchange*0.001f;
       
        speedgoloba.Time += Time_speed*0.001f;

        speedgoloba.rotatspeed += rotatspeedchange*0.1f;

    }
}
