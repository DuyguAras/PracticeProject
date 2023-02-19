using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D r2d;
    private Vector3 charPos;
    
    
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        charPos = transform.position;
    }

    
    void Update()
    {
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos;
        r2d. velocity = new Vector2(speed, 0.0f);
        
    }
}
