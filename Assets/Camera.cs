using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = new(target.transform.position.x,target.transform.position.y,0f);

        transform.position = vector3;
       
    }
}
