using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Font letras;
    public Font texto;
    double time = 0;
    private double conversor = BrosYBoton.conversor;
    private double conversory = BrosYBoton.conversory;


    private void Start()
    {
        if(ElContador.deaths > PlayerPrefs.GetInt("record", 0))
        {
            PlayerPrefs.SetInt("record", ElContador.deaths);
        }
    }
    private void Update()
    {
        time += Time.deltaTime;
    }
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        GUIStyle estilo = new GUIStyle();
        myStyle.fontSize = (int)(100 * conversor);
        estilo.fontSize = (int)(40 * conversor);
        myStyle.normal.textColor = Color.white;
        estilo.normal.textColor = Color.white;
        myStyle.font = letras;
        estilo.font = texto;
        GUI.Label(new Rect((int)(310 * conversor), (int)(10 * conversory), (int)(200 * conversor), (int)(200 * conversory)), "GAME OVER ", myStyle);
        if (GUI.Button(new Rect((int)(750 * conversor), (int)(380 * conversory), (int)(200 * conversor), (int)(100 * conversory)), "", estilo))
        {
            SceneManager.LoadScene("enter");
            naziSeMueve.counter = 0;
            BulletBeh.vidas = 1;
        }
        if (time > 3)
        {

            GUI.Label(new Rect((int)(10 * conversor), (int)(150 * conversory), (int)(100 * conversor), (int)(100 * conversory)), "Comrade Stalin didn't acctually die. He just went to have a rest and ", estilo);
            GUI.Label(new Rect((int)(10 * conversor), (int)(190 * conversory), (int)(100 * conversor), (int)(100 * conversory)), "                        then killed all the remaining nazis.", estilo);
        }
        if (time > 6)
        {
            GUI.Label(new Rect((int)(10 * conversor), (int)(230 * conversory), (int)(100 * conversor), (int)(100 * conversory)), "                             Remember who won WW2.", estilo);
        }
        
        
           
        if (time > 7)        
        {
            estilo.fontSize = (int)(70 * conversor);
            GUI.Label(new Rect((int)(10 * conversor), (int)(320 * conversory), (int)(100 * conversor), (int)(100 * conversory)), "People killed: 0 ", estilo);
        }
        if (time > 8)
        {
            GUI.Label(new Rect((int)(10 * conversor), (int)(420 * conversory), (int)(100 * conversor), (int)(100 * conversory)), "Nazis killed:  " + ElContador.deaths, estilo);
        }
        if (time > 9)
        {
            
            GUI.Label(new Rect((int)(10 * conversor), (int)(520 * conversory), (int)(100 * conversor), (int)(100 * conversory)), "Your Highscore: " + PlayerPrefs.GetInt("record", 0), estilo);
        }
        estilo.fontSize = (int)(120 * conversor);

        if (time > 10)
        {
            if (GUI.Button(new Rect((int)(750 * conversor), (int)(380 * conversory), (int)(200 * conversor), (int)(100 * conversory)), "Retry", estilo))
            {
                SceneManager.LoadScene("enter");
                naziSeMueve.counter = 0;
                BulletBeh.vidas = 1; 
            }
        }

    }
}
