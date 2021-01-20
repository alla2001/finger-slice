using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class update_score : MonoBehaviour
{



    void FixedUpdate()
    {
        GetComponent<TextMeshProUGUI>().text = ((int)playerInfo.score).ToString();
    }
}
