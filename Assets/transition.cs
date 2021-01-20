using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class transition : MonoBehaviour
{
    public bool left;
    // Start is called before the first frame update
    void Start()
    {
        RectTransform rt = this.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(Screen.width/2, rt.sizeDelta.y);
        if (left)
        {
            rt.transform.localPosition = new Vector2((-Screen.width / 2 - Screen.width / 4), 0);
        }
        else
        {
            rt.transform.localPosition = new Vector2((Screen.width / 2 + Screen.width / 4), 0);
        }
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
