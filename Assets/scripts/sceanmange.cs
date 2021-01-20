using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceanmange : MonoBehaviour
{
    public GameObject player;
    public string scene_to_load_on_player_death;
    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            StartCoroutine(i());
        }
    }
    IEnumerator i()
    {
        yield return new WaitForSeconds(2);
        playerInfo.score = 0;
        SceneManager.LoadScene("menu");
    }
}
