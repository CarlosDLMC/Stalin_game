using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBeh : MonoBehaviour
{
    private float speed = -10f;
    public Rigidbody2D rb;
    public static int vidas = 10000000;
    public GameObject impacto;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void Update()
    {
        Destroy(gameObject, 3);
    }
    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if (hitinfo.gameObject.name == "Stalin")
        {
            Destroy(gameObject);
            Instantiate(impacto, transform.position, transform.rotation);
            vidas--;
        }
    }

}
