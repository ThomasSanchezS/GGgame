using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonReiniciar(){
        SceneManager.LoadScene("Nivel1");
   }
   public void BotonMenu(){
    SceneManager.LoadScene("Menu");
   }
}
