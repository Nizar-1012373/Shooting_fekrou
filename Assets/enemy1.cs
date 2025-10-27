using System;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position= new Vector3(-2, 0, 7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0.50f, 0, 0);
    }
}
