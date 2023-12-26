using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float force=1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (0,force),ForceMode2D.Impulse);
        }
    }
}
