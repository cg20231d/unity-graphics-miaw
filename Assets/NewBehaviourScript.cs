using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float m_flapStrength = 15;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bird";
    }
    public float rotationSpeed = 90;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * m_flapStrength;
        }
    //  transform.Rotate(0,0, rotationSpeed * Time.deltaTime);   
    }
}
