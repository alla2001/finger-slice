using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_effect : MonoBehaviour
{
    public  GameObject player;
    Sprite s;
    public Color color1, color2, color3, color4;
    // Start is called before the first frame update
    void Start()
    {
        s = player.GetComponent<SpriteRenderer>().sprite;
        while (color1 == color2 || color2 == color3 || color3 == color4 || color1 == color3 || color1 == color4)
        {

            color1 = s.texture.GetPixel(Random.Range(0, s.texture.width), Random.Range(0, s.texture.height));
            color2 = s.texture.GetPixel(Random.Range(s.texture.width / 2, s.texture.width), Random.Range(s.texture.height / 2, s.texture.height));
            color3 = s.texture.GetPixel(Random.Range(0, s.texture.width / 2), Random.Range(0, s.texture.height / 2));
            color4 = s.texture.GetPixel(Random.Range(0, s.texture.width), Random.Range(0, s.texture.height));
            color1.a = 1; color2.a = 1; color3.a = 1; color4.a = 1;
        }
        
        ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
        settings.startColor =new ParticleSystem.MinMaxGradient(  color1, color2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
