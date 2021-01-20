using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_ui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (playerInfo.score!=0)
        {
            GetComponent<TextMeshPro>().text = playerInfo.score.ToString();
        }
       
    }
    

}
