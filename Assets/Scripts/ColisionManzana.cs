using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisionManzana : MonoBehaviour
{
    public GameObject yo;
    //public GameObject Manzanas;
    public float xPos, zPos;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        xPos = Random.Range(-14, 14);
        zPos = Random.Range(-10, 10);
        if (other.gameObject.tag == "Player")
        {
            int counter = 0;
            while (counter < 1)
            {
                Destroy(yo);
                Instantiate(yo, new Vector3(xPos, 1.01f, zPos), Quaternion.identity);
                counter++;
            }
    
           
        }

    }

}
