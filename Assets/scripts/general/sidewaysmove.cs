using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidewaysmove : MonoBehaviour
{
    Camera c;
    
    GameObject empty1, empty2;
    
   
    
    bool movingright = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        c = Camera.main;
        movingright = Random.Range(0, 2).Equals(1);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        //print(movingright);


        if (movingright == true)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(c.ScreenToWorldPoint(new Vector3(c.pixelWidth, 0, 0)).x + 1.3f, this.transform.position.y, 0), speedgoloba.Time);
            StartCoroutine(i());
        }

        if (c.WorldToScreenPoint(this.transform.position + new Vector3(1.5f, 0, 0)).x >= c.pixelWidth && movingright == true)
        {

            movingright = false;

        }
        if (movingright == false)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(c.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 1.3f, this.transform.position.y, 0), speedgoloba.Time);
            StartCoroutine(i());
        }
        if (c.WorldToScreenPoint(this.transform.position + new Vector3(-1.5f, 0, 0)).x <= 0 && movingright == false)
        {

            movingright = true;

        }
       



       
    
    }

     IEnumerator i()
    {
        yield return new WaitForSeconds(10);
    }

  
}
