using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class display_skins : MonoBehaviour
{
    public GameObject image_pref;
    // Start is called before the first frame update
    void Start()
    {
        Camera c = Camera.main;
        Sprite[] list= Resources.LoadAll<Sprite>("skins");
        print(list.Length);
        Vector2 pos;
        print(image_pref.GetComponent<RectTransform>().sizeDelta.y);
        pos.y = Screen.height/2;
        pos.x = -(float) ((Screen.width /2)  +( (Screen.width) * (0.25/3) + (image_pref.GetComponent<RectTransform>().sizeDelta.x/2)));
        int x=0;
       foreach(Sprite s in list)
        {

            GameObject a = Instantiate(image_pref, this.gameObject.transform);
            
            a.GetComponent<RectTransform>().anchoredPosition = pos;
            a.GetComponent<Image>().sprite = s;
            pos.x = Screen.width * (0.25f / 3) + image_pref.GetComponent<RectTransform>().sizeDelta.x;
            x++;
            if (x == 3)
            {
                pos.x = Screen.width * (0.25f / 3) + (image_pref.GetComponent<RectTransform>().sizeDelta.x / 2);
            }
        }


    }

   
}
