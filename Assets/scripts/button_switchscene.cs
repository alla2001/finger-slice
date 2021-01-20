using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_switchscene : MonoBehaviour
{
    public string scene;
    public Animation anima;
  
    public void load()
    {

        StartCoroutine(i());

    }
    IEnumerator i()
    {
        anima.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(scene);
    }
}
   
    


