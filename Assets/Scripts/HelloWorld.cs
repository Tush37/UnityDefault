using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 200;
    public float speed = 20;

    bool isDragable = false;
    //Rigidbody rb;

    void OnMouseDrag()
    {
        isDragable = true;
    }
    void FixedUpdate()
    {
        if (isDragable)
        {

            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            //rb.AddTorque(Vector3.up * rotX);
            //rb.AddTorque(Vector3.right * rotY);
            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.right, -rotY);

        }


    }
    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            isDragable = false;
            //transform.Rotate(0, 0.3f, 0);
        }
        if (!isDragable)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * speed);

        }
    }
}
