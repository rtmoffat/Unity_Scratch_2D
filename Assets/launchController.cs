using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class launchController : MonoBehaviour
{
    private int load=0;
    private Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update() { 
        if(Input.GetKey(KeyCode.Space))
        {
            Rigidbody2D rb= GetComponent<Rigidbody2D>();
            rb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
            rb.AddForce(new Vector2 (0f, 5000f));
           
        }
    }
}
