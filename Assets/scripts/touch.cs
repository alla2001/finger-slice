using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class touch : MonoBehaviour
{
 
    void Update()
    {
        
    }
    public void touche()
    {

        print("touch");
        SceneManager.LoadScene("gameplay");
    }
   
}
