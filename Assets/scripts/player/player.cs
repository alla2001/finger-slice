using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{


    [Range(0f, 0.2f)]
    public float time;
    Camera c;
    
    Vector3 v;
    public GameObject particl;

    // Start is called before the first frame update
    void Start()
    {

        c = Camera.main;

        InvokeRepeating("score", 0, 1);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (v != c.ScreenToWorldPoint(Input.mousePosition))
        {
            v = c.ScreenToWorldPoint(Input.mousePosition);
            this.transform.LookAt(v,Vector3.forward);
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "killer")
        {
            
            Instantiate(particl,this.transform.position,Quaternion.identity);
            
           
            Destroy(this.gameObject);

        }
    }
    void score()
    {
        playerInfo.addscore();
    }
    private void FixedUpdate()
    {
        
        this.transform.position = new Vector3(Vector2.Lerp(this.transform.position, c.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y)), time).x
            ,Vector2.Lerp(this.transform.position, c.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y)), time).y
            , this.transform.position.z);
        this.transform.position = new Vector3(Vector2.Lerp(this.transform.position, c.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y)), time).x
            , Vector2.Lerp(this.transform.position, c.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y)), time).y
            , this.transform.position.z);

    }
}
