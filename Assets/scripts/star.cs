using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    [Range(0f,-0.1f)]
    public float star_speed;
    
    void FixedUpdate()
    {
        transform.Translate(star_speed, star_speed, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player") {
            Destroy(this.gameObject);
            }
    }
}
