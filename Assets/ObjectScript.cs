using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float m_flapStrength = 5;
    public bool isAlive = true;
    private Vector2 m_fromCameraPosition;

    private Logic logic;

    // Check if the object hits top or bottom of screen
    private bool isHitScreenEdge() {
        m_fromCameraPosition = Camera.main.WorldToScreenPoint(transform.position);

        if(m_fromCameraPosition.y < 0 || m_fromCameraPosition.y > Camera.main.pixelHeight) return true;
        else return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rigidbody2D.velocity = Vector2.up * m_flapStrength;
        }

        if(isHitScreenEdge()) isAlive = false; 
    }

    // Collision handler
    private void OnCollisionEnter2D(Collision2D other) {
        isAlive = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        logic.addScore();
    }
}
