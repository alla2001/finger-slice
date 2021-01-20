using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class center : MonoBehaviour
{
    Camera c;
    // Start is called before the first frame update
    void Start()
    {
        c = Camera.main;
        this.transform.position = new Vector3(c.ScreenToWorldPoint(new Vector3( c.pixelWidth/2,0,0)).x , this.transform.position.y, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
