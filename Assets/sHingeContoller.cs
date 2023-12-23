using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class sHingeContoller : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Quaternion maxRotation;
    private bool rotated=false;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Quaternion.Angle(originalRotation, transform.rotation) < 45.0f)
            {
                Debug.Log("rotating");
                transform.Rotate(0f, 0f, 1.0f * 3.0f);
            }
        }
     else
        {
            if (Quaternion.Angle(originalRotation, transform.rotation) > 0.0f)
            {
                Debug.Log("De-Rotating");
                transform.Rotate(0f, 0f, -1.0f*3.0f);
            }
        }
    }
}
