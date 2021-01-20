using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]public  GameObject doted_line;
    GameObject[] l;
    [Range(0f,5f)]
    public float spawn_rate_seconds = 0.5f;
    static GameObject d;
    static GameObject v;
    static bool spawn;
    public bool dooo;
    private void Start()
    {
        l = Resources.LoadAll<GameObject>("prefabs/obsicals");
        if (dooo == true)
        {
            InvokeRepeating("p", 0, spawn_rate_seconds);
        }
        else
        {
            InvokeRepeating("spawne", 0, spawn_rate_seconds);
        }
        d= doted_line;

        v = this.gameObject;
    }

    void Update()
    {
        
       

    }
    public static void line()
    {
        Instantiate(d, v.transform.position, Quaternion.identity);
        spawn= false;
    }
    void spawne()
    {
         if ((playerInfo.score % 100) != 0 && spawn == true && playerInfo.score != 0)
         {
                
                int r = Random.Range(0, l.Length);
                Instantiate(l[r], this.transform.position, this.transform.rotation);
                spawn_rate_seconds -= 0.01f;
         }
        
        spawn = true;
    }
    void p()
    {
        print("lol");
        int r = Random.Range(0, l.Length);
        Instantiate(l[r], this.transform.position, this.transform.rotation);
        spawn_rate_seconds -= 0.01f;

    }
    
   
}
