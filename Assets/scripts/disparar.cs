using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    // Start is called before the first frame update
    
    private float tiempo = 0f;
    public Transform firepoint;
    public GameObject bulletPrefab;
    float recarga = 3f;


    // Update is called once per frame
    private void Start()
    {
        Shoot();
    }
    void Update()
    {
       if(tiempo > recarga)
        {
            Shoot();
            tiempo = 0;
            recarga = Random.Range(2f, 3f);

        }
        tiempo += Time.deltaTime;
            
       
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }

}
