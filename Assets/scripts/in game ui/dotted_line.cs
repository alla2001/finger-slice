using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotted_line : MonoBehaviour
{
    public GameObject line_dot;
    [Range(0f,5f)]
    public  Vector2 scale;
    [Range(0f, 1f)]
    public  float sperating_space;

    Vector2 posStart;
    Vector2 posEnd;
   


    
    void Start()
    {

       
        
       
       
       posEnd = new Vector2(this.transform.position.x + 5, this.transform.position.y);
       posStart = new Vector2(this.transform.position.x-5, this.transform.position.y);

        float x;

        for (x = posStart.x; x < posEnd.x; x = x + sperating_space)
        {

            GameObject a= Instantiate(line_dot, new Vector3(x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            a.transform.parent = transform;
            x += sperating_space;
            
        }


    }

   
}
