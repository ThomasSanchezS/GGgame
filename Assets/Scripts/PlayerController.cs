using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controlPersonaje;
    public float ChSpeed = 10f;
    public float movementX;
    public float movementZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementCharacter();
    }

    void MovementCharacter()
    {
        movementX = Input.GetAxis("Horizontal");
        movementZ = Input.GetAxis("Vertical");

        Vector3 mover = transform.right * movementX + transform.forward * movementZ;
        controlPersonaje.Move(mover * ChSpeed * Time.deltaTime);
    }
}
