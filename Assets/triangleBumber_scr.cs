using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangleBumber_scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        collision.collider.attachedRigidbody.AddForce(new Vector2(1f,1f)*2f,ForceMode2D.Impulse);
    }
}
