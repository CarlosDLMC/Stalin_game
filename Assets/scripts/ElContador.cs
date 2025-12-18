using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElContador : MonoBehaviour
{
    public Font letras;
    public static int deaths;
    private static int lifes;
    private double conversory = BrosYBoton.conversory;
    private double conversor = BrosYBoton.conversor;

   


    private void Update()
    {
        deaths = naziSeMueve.counter;
        lifes = BulletBeh.vidas;
        if(lifes < 0)
        {            
            SceneManager.LoadScene(2);
        }
       

    }



    void OnGUI()
    {
            GUIStyle myStyle = new GUIStyle();
            myStyle.fontSize = (int)(70 * conversor);
            myStyle.normal.textColor = Color.white;
            myStyle.font = letras;
            GUI.Label(new Rect((int)(320 * conversor), (int)(10 * conversory), (int)(150 * conversor), (int)(20 * conversory)), "NAZIS KILLED: " + deaths, myStyle);
            GUIStyle vidaStyle = new GUIStyle();
            vidaStyle.fontSize = (int)(30 * conversor);
            vidaStyle.normal.textColor = Color.white;
            GUI.Label(new Rect((int)(20 * conversor), (int)(10 * conversory), (int)(100 * conversor), (int)(20 * conversory)), "Lifes: " + lifes, vidaStyle);

    }


}
