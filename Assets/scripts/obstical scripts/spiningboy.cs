using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiningboy : MonoBehaviour
{
    public GameObject axe,spot1, spot2, spot3, spot4;
    
    // Start is called before the first frame update
    void Start()
    {

        int x = Random.Range(0,3);
        if (x==0)
        {
            Instantiate(axe, spot1.transform.position, spot1.transform.rotation,this.transform);
        }
        else if (x==1)
        {
            Instantiate(axe, spot1.transform.position, spot1.transform.rotation, this.transform);
            Instantiate(axe, spot2.transform.position, spot2.transform.rotation, this.transform);
        }
        else {
            Instantiate(axe, spot1.transform.position, spot1.transform.rotation, this.transform);
            Instantiate(axe, spot2.transform.position, spot2.transform.rotation, this.transform);
            Instantiate(axe, spot3.transform.position, spot3.transform.rotation, this.transform);
            Instantiate(axe, spot4.transform.position, spot4.transform.rotation, this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
