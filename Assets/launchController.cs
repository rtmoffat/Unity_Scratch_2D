using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;



public class launchController : MonoBehaviour
{
    public GameObject launchObject;
    private SpringJoint2D sj;
    private Vector3 originalPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        sj= GetComponent<SpringJoint2D>();
        originalPosition=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            launchObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 50f, 0f));
            
        }
/*        else if(Input.GetKeyUp(KeyCode.Space)) {
        }*/
        void attachBody()
        {
            sj.connectedBody=launchObject.GetComponent<Rigidbody2D>();
        }
        void detatchBody()
        {
            sj.connectedBody = null;
        }
    }
}
