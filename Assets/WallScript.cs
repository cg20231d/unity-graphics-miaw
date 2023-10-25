using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    
    public GameObject wall;
    public float spawnRate = 2;
    private float timer = 0;
    public float offsetRange = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < 2) {
            timer += Time.deltaTime;
        } else {
            
            Instantiate(wall, transform.position + Vector3.up * UnityEngine.Random.Range(-offsetRange, offsetRange), transform.rotation);
            timer = 0;
        }
        
    }
}
