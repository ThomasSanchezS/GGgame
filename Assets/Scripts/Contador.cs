using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contador : MonoBehaviour
{
    public TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "chatarras x" + "0" ;
    }

    public void UpdateContador(float monedas){
        texto.text = "chatarras x" + monedas.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
