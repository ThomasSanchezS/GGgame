using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			gameManager.GameOver();
		}
	}
}
