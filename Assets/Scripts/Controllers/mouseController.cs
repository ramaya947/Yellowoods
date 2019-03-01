using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseController : MonoBehaviour
{

    float horizontalSpeed = 5.0f; 
    float verticalSpeed = 5.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1)){
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            print (h + ", " + v);
            if (Mathf.Abs(h) > Mathf.Abs(v))
                transform.Rotate(0, -h, 0);
            else
                transform.Rotate(v, 0, 0);
        }
        else {
            if (Input.mouseScrollDelta.y > 0){
                transform.position += transform.forward; 
            } 
            else if (Input.mouseScrollDelta.y < 0) {
                transform.position += -transform.forward; 
            }
        }
    }
}
