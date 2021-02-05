using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlanetMaterial : MonoBehaviour
{

    public int res = 512;
    private MeshRenderer mesh;
    public float zoom = 20;
   

    void Start()
    {

        mesh = GetComponent<MeshRenderer>();
        MakeTexture();

    }

    void MakeTexture()
    {
        Texture2D texture = new Texture2D(res, res);

        Color[] pixels = texture.GetPixels();

        for(int y = 0; y < res; y++)
        {
            for(int x = 0; x< res; x++)
            {
                int i = x + y * res;

                float a =Mathf.PerlinNoise(x/zoom, y/zoom);

                if(a < .5f)
                {
                    pixels[i] = new Color(0,0 , 255);
                }
                else
                {
                    pixels[i] = new Color(0, 255, 0);
                }

               // pixels[i] = new Color(a, a, a);
            }
        }

        texture.SetPixels(pixels);
        texture.Apply();

        mesh.material.SetTexture("_MainTex", texture);
    }
   
    void Update()
    {
        


    }
}
