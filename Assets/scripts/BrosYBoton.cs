using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BrosYBoton : MonoBehaviour
{
    public Texture2D Bros;
    public Texture2D Boton;    
    public static Resolution currentResolution;
    public static double conversor;
    public static double conversory;
    public static string resolution;
    public static string witdh;
    public static string height;
    static double ancho;
    static double alto;

    private void Start()
    {
        resolution = Screen.currentResolution.ToString();
        
    }
    
    
    
    /*
    void Start()
    {
        string resolution = Screen.currentResolution.ToString();
        string witdh = resolution.Substring(0, 4);
        double ancho = double.Parse(witdh);
        double puta = 1 * ancho / 1920;
        print(puta);
    }

    */

    private void OnGUI()
    {
        witdh = resolution.Substring(0, 4);
        height = resolution.Substring(7, 4);
        ancho = double.Parse(witdh);
        alto = double.Parse(height);
        conversor = 1.68 * ancho / 1920;
        conversory = 1.68 * alto / 1080;
        GUI.DrawTexture(new Rect((int)(360 * conversor), (int)(10 * conversory), (int)(780 * conversor), (int)(300 * conversory)), Bros, ScaleMode.StretchToFill, false);

        if (GUI.Button(new Rect((int)(460 * conversor), (int)(350 * conversory), (int)(560 * conversor), (int)(150 * conversory)), Boton))
        {
            SceneManager.LoadScene("main");
        }
        GUI.DrawTexture(new Rect((int)(460 * conversor), (int)(350 * conversory), (int)(560 * conversor), (int)(150 * conversory)), Boton, ScaleMode.StretchToFill, false);


    }
}
