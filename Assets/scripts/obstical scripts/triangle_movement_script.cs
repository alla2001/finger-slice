using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle_movement_script : MonoBehaviour
{

    [Range(0f, 1f)]
    public float speed;
    Camera c;
    public Vector3 start, mid, end,target,pos;
    public LineRenderer line;
    
    
   
    

    float t = 0;

    // Start is called before the first frame update

    void Start()
    {
        
        c = Camera.main;
        start = this.transform.localPosition;
        mid = new Vector3(c.ScreenToWorldPoint(new Vector3(c.pixelWidth - 50, 0, 0)).x, start.y - 4, 0);

        end = new Vector3(c.ScreenToWorldPoint(new Vector3(50, 0, 0)).x, start.y - 4, 0);
        Vector3[] points = {start, mid, end, start };

        target = mid;
        line.positionCount = points.Length;
        line.SetPositions(points);
        

    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(i());

        
    }
    IEnumerator  i()
    {

        t = t + 0.01f;
       
        if (t < speed)
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, target, t);
           

        }
        if (target == mid && t >= speed)
        {
            pos = mid;
            target = end;
            
            t = 0;
            
            


        }
        if (target == end && t >= speed)
        {
            pos = end;
            target = start;
            t = 0;
            
            

        }
        if (target == start && t >= speed)
        {
            pos = start;
            target = mid;
            t = 0;
           
            
            

        }
        

        yield return new WaitForSeconds(0);

        
    }
}
