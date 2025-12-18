using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naziSeMueve : MonoBehaviour
{
    public float speed = 4f;
    public GameObject naziMuere;
    public GameObject cabeza;
    public static int counter;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject, 15);
    }
    private void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.name == "Stalin")
        {
            Destroy(gameObject);
            Instantiate(naziMuere, transform.position, transform.rotation);
            Instantiate(cabeza, transform.position, transform.rotation);
            counter++;
        }
    }
   
}
