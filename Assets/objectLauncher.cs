using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectLauncher : MonoBehaviour
{
    private bool launched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) &(!launched))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(0,5000f,0));
            launched= true;
        }
    }
}
