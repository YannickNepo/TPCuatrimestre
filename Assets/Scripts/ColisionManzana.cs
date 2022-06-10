using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisionManzana : MonoBehaviour
{
    public GameObject yo;
    //public GameObject Manzanas;
    public float xPos, zPos;
    public Text MiTexto;
    int Score = 0;
    // Start is called before the first frame update

    void Start()
    {
        MiTexto.text = "";
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
            Destroy(yo);
            Instantiate(yo, new Vector3(xPos, 1.01f, zPos), Quaternion.identity);
            Score += 10;
            MiTexto.text = "PUNTAJE: " + Score;
        }

    }


}
