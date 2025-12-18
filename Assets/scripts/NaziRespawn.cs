using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaziRespawn : MonoBehaviour
{
    private float timer = 0;
    public GameObject nazi;
    float maxTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(timer > maxTime)
        {
            GameObject newnazi = Instantiate(nazi);
            Destroy(newnazi, 8);
            timer = 0;
            maxTime = Random.Range(2f, 4f);
        }
        timer += Time.deltaTime;
    }
}
