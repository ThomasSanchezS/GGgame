using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera camara;
    public float horizontalSpeed;
    public float verticalSpeed;
    private Transform myTransform;
    public float speed;
    private float xAxis, zAxis;

    float h;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed*Input.GetAxis("Mouse X");
        v = verticalSpeed*Input.GetAxis("Mouse Y");

        transform.Rotate(0,h,0);
        camara.transform.Rotate(-v,0,0);
        
        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(xAxis, 0, zAxis);
        myTransform.transform.Translate(movimiento*speed*Time.deltaTime);

    }
}
