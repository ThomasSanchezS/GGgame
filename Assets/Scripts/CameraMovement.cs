using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraMovement : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public Transform Camerarotation;
    public float speedRotation = 10f;
    public float xRotation;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");  

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
       
        Camerarotation.Rotate(Vector3.up * mouseX*speedRotation);
        
        
    }
}
